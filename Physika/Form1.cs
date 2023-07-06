using Handlers;
using System.Diagnostics;

namespace Physika {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            if (DesignerSetup.IsWindows10OrGreater() == true) {
                DesignerSetup.UseImmersiveDarkMode(this.Handle, true);
            }
        }

        private void headerControl1_ValueChanged() {
            hiddenTabControl1.SelectedIndex = headerControl1.Selected;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e) {
            ExecuteCommand("STD_UNIT");
        }
        private void NewUnitConversion() {
            Pages.UnitConverter PgUnitConversion = new Pages.UnitConverter();
            TabPage NewTabPage = new TabPage();
            NewTabPage.Text = "Unit Converter";
            PgUnitConversion.Dock = DockStyle.Fill;
            NewTabPage.Controls.Add(PgUnitConversion);
            hiddenTabControl1.TabPages.Add(NewTabPage);
        }
        private void NewUnitCalculator() {
            Pages.UnitCalculator PgUnitConversion = new Pages.UnitCalculator();
            TabPage NewTabPage = new TabPage();
            NewTabPage.Text = "Unit Calculator";
            PgUnitConversion.Dock = DockStyle.Fill;
            NewTabPage.Controls.Add(PgUnitConversion);
            hiddenTabControl1.TabPages.Add(NewTabPage);
        }
        private void NewEquationTemplateCalculator() {
            Pages.EquationTemplate PgEquationTemplate = new Pages.EquationTemplate();
            TabPage NewTabPage = new TabPage();
            NewTabPage.Text = "Equations";
            PgEquationTemplate.Dock = DockStyle.Fill;
            NewTabPage.Controls.Add(PgEquationTemplate);
            hiddenTabControl1.TabPages.Add(NewTabPage);
        }
        private void Form1_Load(object sender, EventArgs e) {
            Classes.UnitConverter.LoadDimensions();
            Classes.EquationManager.LoadEquations();
            AddIcons();
        }
        public void AddIcons() {
            Classes.ApplicationManager.IsDark = Properties.Settings.Default.THM_DARK_IsDark;
            DesignerSetup.IconSize ScaleIcons = DesignerSetup.IconSize.Small;
            if (Properties.Settings.Default.DIS_ICONS_UseLargeIcons == true) {
                ScaleIcons = DesignerSetup.IconSize.Medium;
            }
            DesignerSetup.SetImageSizes(RenderHandler.DPI());
            buttonGrid1.ButtonSize = DesignerSetup.ScaleSize(buttonGrid1.ButtonSize);
            buttonGrid1.ImageSize = DesignerSetup.ScaleSize(buttonGrid1.ImageSize);
            //DesignerSetup.LinkSVGtoControl(Properties.Resources.NewDeploymentPackage_16x, newToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.OpenFile_16x, openToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.Save_16x, saveToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            DesignerSetup.LinkSVGtoControl(Properties.Resources.Calculator, buttonGrid1.Buttons[0], DesignerSetup.GetSize(DesignerSetup.IconSize.Large));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.PartitionFunction, buttonGrid1.Buttons[1], DesignerSetup.GetSize(DesignerSetup.IconSize.Large));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.Binary, buttonGrid1.Buttons[2], DesignerSetup.GetSize(DesignerSetup.IconSize.Large));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.UnitOfMeasure, buttonGrid1.Buttons[3], DesignerSetup.GetSize(DesignerSetup.IconSize.Large));
                DesignerSetup.LinkSVGtoControl(Properties.Resources.TableFunction, buttonGrid1.Buttons[4], DesignerSetup.GetSize(DesignerSetup.IconSize.Large));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.Operator, buttonGrid1.Buttons[5], DesignerSetup.GetSize(DesignerSetup.IconSize.Large));
        }
        private void unitCalculatorToolStripMenuItem_Click(object sender, EventArgs e) {
            ExecuteCommand("STD_UNITCALC");
        }

        private void calculatorExpressionToolStripMenuItem_Click(object sender, EventArgs e) {
            ExecuteCommand("STD_CALCEXP");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e) {
            ExecuteCommand("STD_CALC");
        }
        private void ExecuteCommand(string Command) {
            SuspendLayout();
            if (Command == "STD_CALC") {
                Pages.Calculator PgCalculator = new Pages.Calculator();
                TabPage NewTabPage = new TabPage();
                NewTabPage.Text = "Calculator";
                PgCalculator.Dock = DockStyle.Fill;
                NewTabPage.Controls.Add(PgCalculator);
                hiddenTabControl1.TabPages.Add(NewTabPage);
            }
            else if (Command == "STD_CALCEXP") {
                Pages.CalculatorExpression PgExpressionCalculator = new Pages.CalculatorExpression();
                TabPage NewTabPage = new TabPage();
                NewTabPage.Text = "Expression Calculator";
                PgExpressionCalculator.Dock = DockStyle.Fill;
                NewTabPage.Controls.Add(PgExpressionCalculator);
                hiddenTabControl1.TabPages.Add(NewTabPage);
            }
            else if (Command == "STD_CALCPROG") {
                Pages.CalculatorExpression PgExpressionCalculator = new Pages.CalculatorExpression();
                TabPage NewTabPage = new TabPage();
                NewTabPage.Text = "Expression Calculator";
                PgExpressionCalculator.Dock = DockStyle.Fill;
                NewTabPage.Controls.Add(PgExpressionCalculator);
                hiddenTabControl1.TabPages.Add(NewTabPage);
            }
            else if (Command == "STD_UNITCALC") {
                NewUnitCalculator();
            }
            else if (Command == "STD_UNIT") {
                NewUnitConversion();
            }
            else if (Command == "STD_EQ") {
                NewEquationTemplateCalculator();
            }
            ResumeLayout();
        }
        private void equationsToolStripMenuItem_Click(object sender, EventArgs e) {
            NewEquationTemplateCalculator();
        }

        private void autoscaleResultToolStripMenuItem_Click(object sender, EventArgs e) {
            Classes.UnitSystem.AutoScale = autoscaleResultToolStripMenuItem.Checked;
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e) {
            this.TopMost = !this.TopMost;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void buttonGrid1_ButtonClicked(object Sender, ODModules.GridButton Button, Point GridLocation) {
            ExecuteCommand(Button.Command);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            Classes.ApplicationManager.OpenInternalApplicationOnce(new Form2());
        }
    }
    [Serializable]
    public class CP {
        public string Test = "";
    }
}