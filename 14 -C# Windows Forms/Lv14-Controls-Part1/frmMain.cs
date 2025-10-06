using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lv14_Controls_Part1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnShowDialogForm_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void btnShowRadiobtnsForm_Click(object sender, EventArgs e)
        {
            Form frm = new frmRadioButtonsGroup();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmTextBox();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmSimpleCalculator();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new frmImageBox();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new frmImagesExcercise();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form maskedTextBox = new frmMaskedTextBox();
            maskedTextBox.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form comboBox = new frmComboBox();
            comboBox.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form combobox = new frmComboBoxImages();
            combobox.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form linkLabel = new frmLinkLabel();
            linkLabel.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form checkBoxList = new frmCheckBoxList();
            checkBoxList.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form dateTimePicker = new frmDateTimePicker();
            dateTimePicker.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form monthCalender = new frmMonthCalender();
            monthCalender.ShowDialog();
        }

        private void btnTimerForm_Click(object sender, EventArgs e)
        {
            Form timer = new frmTimer();
            timer.ShowDialog();
        }

        private void btnNotifyIcon_Click(object sender, EventArgs e)
        {
            Form notifyIcon = new frmNotifyIcon();
            notifyIcon.ShowDialog();
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            Form treeView = new frmTreeView();
            treeView.ShowDialog();
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            Form progressBar = new frmProgressBar();
            progressBar.ShowDialog();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            Form listView = new frmListView();  
            listView.ShowDialog();
        }

        private void btnErrorProvider_Click(object sender, EventArgs e)
        {
            Form errorProvider = new frmErrorProvider();
            errorProvider.ShowDialog();
        }

        private void btnTrackBar_Click(object sender, EventArgs e)
        {
            Form trackBar = new frmTrackBar();
            trackBar.ShowDialog();
        }

        private void btnNeumericUpDown_Click(object sender, EventArgs e)
        {
            Form neumaricUpDown = new frmNeumaricUpDown();
            neumaricUpDown.ShowDialog();
        }

        private void btnTapPage_Click(object sender, EventArgs e)
        {
            Form tabControl = new frmTapPage();
            tabControl.ShowDialog();
        }

        private void btnGbvsPanel_Click(object sender, EventArgs e)
        {
            Form groupboxVsPanel = new frmGroupboxVsPanel();
            groupboxVsPanel.ShowDialog();
        }

        private void btnDialogs_Click(object sender, EventArgs e)
        {
            Form dialogs = new frmDialogs();
            dialogs.ShowDialog();
        }
    }
}
