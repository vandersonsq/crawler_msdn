using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ConsultaMSDN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var wc = new WebClient();
            string pagina = wc.DownloadString("https://social.msdn.microsoft.com/Forums/pt-br/home?filter=answered&sort=repliesdesc&searchTerm=c%23");

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(pagina);

            dataGridView1.Rows.Clear();

            string id = string.Empty;
            string titulo = string.Empty;
            string postagem = string.Empty;
            string exibicao = string.Empty;
            string resposta = string.Empty;
            string link = string.Empty;

            foreach (var node in htmlDocument.GetElementbyId("threadList").ChildNodes)
            {
                if (node.Attributes.Count > 0)
                {
                    id = node.Attributes["data-threadid"].Value;
                    link = "https://social.msdn.microsoft.com/Forums/pt-br/" + id;
                    titulo = node.Descendants().First(x => x.Id.Equals("threadTitle_" + id)).InnerText;
                    postagem = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("lastpost")).InnerText.Replace("\n", "").Replace("  ", ""));
                    exibicao = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("viewcount")).InnerText);
                    resposta = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("replycount")).InnerText);

                    if (!string.IsNullOrEmpty(titulo))
                    {
                        dataGridView1.Rows.Add(titulo, postagem, exibicao, resposta, link);
                    }
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
