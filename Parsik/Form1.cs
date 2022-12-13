using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AngleSharp;
using Octokit;
using System.Data;

namespace Parsik
{
    public partial class Parser : Form
    {
        public Parser()
        {
            InitializeComponent();
        }

        private void buttonGetInitials_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (comboBoxGroups.Text.ToString() == "250504")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM students.`250504`", dataBase.getConnection());
                adapter.SelectCommand= command;
            }
            else if(comboBoxGroups.Text.ToString() == "250505")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM students.`250505`", dataBase.getConnection());
                adapter.SelectCommand = command;
            }
            else if (comboBoxGroups.Text.ToString() == "250701")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM students.`250701`", dataBase.getConnection());
                adapter.SelectCommand = command;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM students.`250702`", dataBase.getConnection());
                adapter.SelectCommand = command;
            }    

            adapter.Fill(table);
            checkedListBoxInitials.DataSource = table;
            checkedListBoxInitials.DisplayMember = table.Columns[0].ToString();
            checkedListBoxInitials.ValueMember = table.Columns[1].ToString();
        }

        private async void buttonCompare_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim() != "")
            {
                var matchPercentage = 0.0;
                var matchLink = string.Empty;
                var client = new GitHubClient(new ProductHeaderValue("ARRY"));

                SearchCodeResult ListLnaguageC = await client.Search.SearchCode(
                  new SearchCodeRequest(".c")
                  {
                      In = new CodeInQualifier[] { CodeInQualifier.Path },
                      Language = Language.C,
                      Repos = new RepositoryCollection { checkedListBoxInitials.SelectedValue.ToString() }
                  });

                SearchCodeResult ListLnaguageCpp = await client.Search.SearchCode(
                  new SearchCodeRequest(".cpp")
                  {
                      In = new CodeInQualifier[] { CodeInQualifier.Path },
                      Language = Language.CPlusPlus,
                      Repos = new RepositoryCollection { checkedListBoxInitials.SelectedValue.ToString() }
                  });

                for (int i = 0; i < ListLnaguageC.Items.Count; i++)
                {
                    var path = ListLnaguageC.Items[i].Path.ToString();
                    var rawUrl = "https://raw.githubusercontent.com/" + checkedListBoxInitials.SelectedValue.ToString() + "/master/" + path;

                    var config = Configuration.Default.WithDefaultLoader();
                    var context = BrowsingContext.New(config);
                    var document = await context.OpenAsync(rawUrl);
                    var items = document.QuerySelectorAll("pre");

                    foreach (var item in items)
                    {
                        var sourceCode = item.TextContent.Replace("\n", "");
                        var inputCode = richTextBox1.Text.ToString().Replace("\n", "");
                        var single1 = Shingles.GetShingleHashes(sourceCode, 2);
                        var single2 = Shingles.GetShingleHashes(inputCode, 2);

                        var temp = Shingles.Compare(single1, single2);
                        if (temp > matchPercentage)
                        {
                            matchPercentage = temp;
                            matchLink = rawUrl;
                        }
                    }
                }

                for (int i = 0; i < ListLnaguageCpp.Items.Count; i++)
                {
                    var path = ListLnaguageCpp.Items[i].Path.ToString();
                    var rawUrl = "https://raw.githubusercontent.com/" + checkedListBoxInitials.SelectedValue.ToString() + "/master/" + path;

                    var config = Configuration.Default.WithDefaultLoader();
                    var context = BrowsingContext.New(config);
                    var document = await context.OpenAsync(rawUrl);
                    var items = document.QuerySelectorAll("pre");

                    foreach (var item in items)
                    {
                        var sourceCode = item.TextContent.Replace("\n", "");
                        var inputCode = richTextBox1.Text.ToString().Replace("\n", "");
                        var single1 = Shingles.GetShingleHashes(sourceCode, 2);
                        var single2 = Shingles.GetShingleHashes(inputCode, 2);

                        var temp = Shingles.Compare(single1, single2);
                        if (temp > matchPercentage)
                        {
                            matchPercentage = temp;
                            matchLink = rawUrl;
                        }
                    }
                }
                MessageBox.Show(matchPercentage.ToString() + "%");
                MessageBox.Show(matchLink.ToString());
            }
            else
            {
                MessageBox.Show("Paste the text");
            }
        }

        private void checkedListBoxInitials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
