namespace RelativeURLs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.CSSText = "body {font-family: Arial;}";

            this.htmlEditControl1.BaseURL = "https://zoople.tech";
            this.htmlEditControl1.UseRelativeURLs = true;

            this.htmlEditControl1.DocumentHTML = "<p>\r\n\t<a href=\"test.html\" >testing</a>\r\n</p>\r\n<p>\r\n\ttesting\r\n</p>";
        }

        private void htmlEditControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
