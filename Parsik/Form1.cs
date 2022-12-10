using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AngleSharp;
using Octokit;


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
                List<Students> students250504 = new List<Students>();
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
                students250504.Add(new Students() { name = "Шалль Герман Эдуардович", gitHub = "https://github.com/gerushenka/gerazitory" });
                students250504.Add(new Students() { name = "Шимчик Михаил Викторович", gitHub = "https://github.com/mishashim10/desktop-tutorial" });
                students250504.Add(new Students() { name = "Щербо Павел Андреевич", gitHub = "https://github.com/Pavel-Shcherbo/bsuir" });
                students250504.Add(new Students() { name = "Яцкевич Александр Дмитриевич", gitHub = "https://github.com/Alexandr022/Alexandr-Yatskevich-250504" });
                students250504.Add(new Students() { name = "Алхава Руслан Абдулькаримович", gitHub = "https://github.com/Willygodx/Ruslan" });
                students250504.Add(new Students() { name = "Антоненко Александр Владимирович", gitHub = "https://github.com/a9ek0/antonenko" });
                students250504.Add(new Students() { name = "Бойко Роман Сергеевич", gitHub = "https://github.com/NiRRiT33/1" });
                students250504.Add(new Students() { name = "Борисевич Матвей Игоревич", gitHub = "GwinBest/oaip" });
                students250504.Add(new Students() { name = "Вильчинский Вадим Сергеевич", gitHub = "https://github.com/Vadimvill/OAIP" });
                students250504.Add(new Students() { name = "Гутковский Артем Сергеевич", gitHub = "https://github.com/GutkovskiyArtem/OAiP-250504.git" });
                students250504.Add(new Students() { name = "Дмитриев Павел Андреевич", gitHub = "https://github.com/gklf-pixel/Dpavel" });
                students250504.Add(new Students() { name = "Казаченко Павел Евгеньевич", gitHub = "https://github.com/mxrpheus6/OAiP" });
                students250504.Add(new Students() { name = "Мальченко Артём Евгеньевич", gitHub = "https://github.com/artem-00/AOiP_Mal" });
                students250504.Add(new Students() { name = "Манько Иван Кириллович", gitHub = "https://github.com/vanyamanko/Ivan-Manko" });
                students250504.Add(new Students() { name = "Пигулевский Константин Сергеевич", gitHub = "bagggage/bsuir-labs" });
                students250504.Add(new Students() { name = "Савицкий Михаил Александрович", gitHub = "https://github.com/Awrdo/OAiP-250504-" });
                students250504.Add(new Students() { name = "Слинько Артём Геннадьевич", gitHub = "https://github.com/artemslinko/" });
                students250504.Add(new Students() { name = "Спасёнов Юрий Леонидович", gitHub = "https://github.com/sefin123/repository-s-sefin" });
                students250504.Add(new Students() { name = "Тарбаев Дмитрий Сергеевич", gitHub = "https://github.com/Cupru-m/-" });
                checkedListBoxInitials.DataSource = students250504;
                checkedListBoxInitials.DisplayMember = "name";
                checkedListBoxInitials.ValueMember = "gitHub";
            }
            else
            {
                checkedListBoxInitials.DataSource = null;
            }
        }

        private async void buttonCompare_Click(object sender, EventArgs e)
        {
            var matchPercentage = 0.0;
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

                    matchPercentage = Shingles.Compare(single1, single2);
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

                    matchPercentage = Shingles.Compare(single1, single2);

                }
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
