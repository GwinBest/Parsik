using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AngleSharp;
using Octokit;
using System.Data;
using System.Data.Common;

namespace Parsik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetInitials_Click(object sender, EventArgs e)
        {
            if (comboBoxGroups.Text.ToString() == "250504")
            {
                DataBase dataBase = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM students.`250504`", dataBase.getConnection());
                
                adapter.SelectCommand= command;
                adapter.Fill(table);
                checkedListBoxInitials.DataSource = table;
                checkedListBoxInitials.DisplayMember = table.Columns[0].ToString();
                checkedListBoxInitials.ValueMember = table.Columns[1].ToString();



                /*List<Students> students250504 = new List<Students>();
                students250504.Add(new Students() { name = "Василевич Дмитрий Викторович", gitHub = "gexgener1l/vasilevich-oaip" });
                students250504.Add(new Students() { name = "Закоркин Илья Денисович", gitHub = "Ilyas-12345/Projects.For.Laboratory" });
                students250504.Add(new Students() { name = "Кабачевский Дмитрий Вячеславович", gitHub = "KabacheuskyDmitry/OAiP" });
                students250504.Add(new Students() { name = "Кароткая Полина Сергеевна", gitHub = "whitedragon077/karotkaya_oaip" });
                students250504.Add(new Students() { name = "Кольянов Илья Дмитриевич", gitHub = "Krame1S/OAiP-Kolyanov" });
                students250504.Add(new Students() { name = "Лагодич Илья Романович", gitHub = "elegardooo/OAIP" });
                students250504.Add(new Students() { name = "Моисеев Владислав Сергеевич", gitHub = "vladmoiseev/vladislavmoiseev-p" });
                students250504.Add(new Students() { name = "Солодков Максим Дмитриевич", gitHub = "MaximSolodkovVMSIS/MaximSolodkov" });
                students250504.Add(new Students() { name = "Таврель Максим Дмитриевич", gitHub = "Maksentiu/Ksis" });
                students250504.Add(new Students() { name = "Телешов Андрей Витальевич", gitHub = "TeleshovAndrey/MyHome" });
                students250504.Add(new Students() { name = "Хвесько Павел Сергеевич", gitHub = "PahanHvesco/OAiP" });
                students250504.Add(new Students() { name = "Шалль Герман Эдуардович", gitHub = "gerushenka/gerazitory" });
                students250504.Add(new Students() { name = "Шимчик Михаил Викторович", gitHub = "mishashim10/desktop-tutorial" });
                students250504.Add(new Students() { name = "Щербо Павел Андреевич", gitHub = "Pavel-Shcherbo/bsuir" });
                students250504.Add(new Students() { name = "Яцкевич Александр Дмитриевич", gitHub = "Alexandr022/Alexandr-Yatskevich-250504" });
                students250504.Add(new Students() { name = "Алхава Руслан Абдулькаримович", gitHub = "Willygodx/Ruslan" });
                students250504.Add(new Students() { name = "Антоненко Александр Владимирович", gitHub = "a9ek0/antonenko" });
                students250504.Add(new Students() { name = "Бойко Роман Сергеевич", gitHub = "NiRRiT33/1" });
                students250504.Add(new Students() { name = "Борисевич Матвей Игоревич", gitHub = "GwinBest/oaip" });
                students250504.Add(new Students() { name = "Вильчинский Вадим Сергеевич", gitHub = "Vadimvill/OAIP" });
                students250504.Add(new Students() { name = "Гутковский Артем Сергеевич", gitHub = "GutkovskiyArtem/OAiP-250504.git" });
                students250504.Add(new Students() { name = "Дмитриев Павел Андреевич", gitHub = "gklf-pixel/Dpavel" });
                students250504.Add(new Students() { name = "Казаченко Павел Евгеньевич", gitHub = "mxrpheus6/OAiP" });
                students250504.Add(new Students() { name = "Мальченко Артём Евгеньевич", gitHub = "artem-00/AOiP_Mal" });
                students250504.Add(new Students() { name = "Манько Иван Кириллович", gitHub = "vanyamanko/Ivan-Manko" });
                students250504.Add(new Students() { name = "Пигулевский Константин Сергеевич", gitHub = "bagggage/bsuir-labs" });
                students250504.Add(new Students() { name = "Савицкий Михаил Александрович", gitHub = "Awrdo/OAiP-250504-" });
                students250504.Add(new Students() { name = "Слинько Артём Геннадьевич", gitHub = "artemslinko/-" });
                students250504.Add(new Students() { name = "Спасёнов Юрий Леонидович", gitHub = "sefin123/repository-s-sefin" });
                students250504.Add(new Students() { name = "Тарбаев Дмитрий Сергеевич", gitHub = "Cupru-m/-" });
                checkedListBoxInitials.DataSource = students250504;
                checkedListBoxInitials.DisplayMember = "name";
                checkedListBoxInitials.ValueMember = "gitHub";*/
            }
            else
            {
                checkedListBoxInitials.DataSource = null;
            }
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
