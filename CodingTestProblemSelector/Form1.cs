using CefSharp.WinForms;
using CefSharp;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace CodingTestProblemSelector
{
    public partial class Form1 : Form
    {
        private bool[] checkLevels = new bool[6];
        private readonly string RootURL = "https://programmers.co.kr/";

        public Form1()
        {
            InitializeComponent();
        }

        // ����Ʈ �ڽ� ���� ü����
        private void linkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ���α׷��ӽ� ����Ʈ�� �̵�
        private void programmersLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        // ���� ���õ� üũ�ڽ� ������ �ǰ��Ͽ� ��ũ�� �����ɴϴ�.
        private void collectProblenBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            checkLevels[0] = checkBox0.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkLevels[1] = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkLevels[2] = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkLevels[3] = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkLevels[4] = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkLevels[5] = checkBox5.Checked;
        }
    }
}