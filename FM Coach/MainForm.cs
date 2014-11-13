using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM_Coach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            numericUpDownCAFitness_ValueChanged(this, null);
            numericUpDownCAGoalkeepers_ValueChanged(this, null);
            numericUpDownCATactical_ValueChanged(this, null);
            numericUpDownCATechnical_ValueChanged(this, null);
            numericUpDownCAMental_ValueChanged(this, null);
            numericUpDownCADefending_ValueChanged(this, null);
            numericUpDownCAAttacking_ValueChanged(this, null);
        }

        /****** Events ******/

        #region Menu Items events

        private void documentaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocBox doc = new DocBox();
            doc.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void resetFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDownCAAttacking.Value = 10;
            numericUpDownCADefending.Value = 10;
            numericUpDownCAFitness.Value = 10;
            numericUpDownCAGoalkeepers.Value = 10;
            numericUpDownCAMental.Value = 10;
            numericUpDownCATactical.Value = 10;
            numericUpDownCATechnical.Value = 10;
            numericUpDownMADetermination.Value = 10;
            numericUpDownMADiscipline.Value = 10;
            numericUpDownMAMotivating.Value = 10;
        }

        private void defaultenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguage(new CultureInfo(""));
        }

        private void frenchfrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguage(new CultureInfo("fr-FR"));
        }

        #endregion

        #region NumericUpDown events

        private void numericUpDownCAFitness_ValueChanged(object sender, EventArgs e)
        {
            CoachingSpecStrength strength = new CoachingSpecStrength(
                numericUpDownCAFitness.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);
            CoachingSpecAerobic aerobic = new CoachingSpecAerobic(
                numericUpDownCAFitness.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            updateStars(flowLayoutPanelTSStrength, strength.getNumberOfStars());
            updateStars(flowLayoutPanelTSAerobic, aerobic.getNumberOfStars());
        }

        private void numericUpDownCAGoalkeepers_ValueChanged(object sender, EventArgs e)
        {
            CoachingSpecStopping stopping = new CoachingSpecStopping(
                numericUpDownCAGoalkeepers.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);
            CoachingSpecHandling handling = new CoachingSpecHandling(
                numericUpDownCAGoalkeepers.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            updateStars(flowLayoutPanelTSStopping, stopping.getNumberOfStars());
            updateStars(flowLayoutPanelTSHandling, handling.getNumberOfStars());
        }

        private void numericUpDownCATactical_ValueChanged(object sender, EventArgs e)
        {
            CoachingSpecTactics tactics = new CoachingSpecTactics(
                numericUpDownCATactical.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            updateStars(flowLayoutPanelTSTactics, tactics.getNumberOfStars());

            numericUpDownCADefending_ValueChanged(sender, e);
            numericUpDownCAAttacking_ValueChanged(sender, e);
        }

        private void numericUpDownCATechnical_ValueChanged(object sender, EventArgs e)
        {
            CoachingSpecBallControl ballControl = new CoachingSpecBallControl(
                numericUpDownCATechnical.Value,
                numericUpDownCAMental.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            CoachingSpecShooting shooting = new CoachingSpecShooting(
                numericUpDownCATechnical.Value,
                numericUpDownCAAttacking.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            updateStars(flowLayoutPanelTSBallControl, ballControl.getNumberOfStars());
            updateStars(flowLayoutPanelTSShooting, shooting.getNumberOfStars());
        }

        private void numericUpDownCAMental_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCATechnical_ValueChanged(sender, e);
        }

        private void numericUpDownCADefending_ValueChanged(object sender, EventArgs e)
        {
            CoachingSpecDefending defending = new CoachingSpecDefending(
                numericUpDownCADefending.Value,
                numericUpDownCATechnical.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            updateStars(flowLayoutPanelTSDefending, defending.getNumberOfStars());
        }

        private void numericUpDownCAAttacking_ValueChanged(object sender, EventArgs e)
        {
            CoachingSpecAttacking attacking = new CoachingSpecAttacking(
                numericUpDownCAAttacking.Value,
                numericUpDownCATechnical.Value,
                numericUpDownMADetermination.Value,
                numericUpDownMADiscipline.Value,
                numericUpDownMAMotivating.Value);

            updateStars(flowLayoutPanelTSAttacking, attacking.getNumberOfStars());
        }

        private void numericUpDownMADetermination_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCAFitness_ValueChanged(sender, e);
            numericUpDownCAGoalkeepers_ValueChanged(sender, e);
            numericUpDownCATactical_ValueChanged(sender, e);
            numericUpDownCATechnical_ValueChanged(sender, e);
            numericUpDownCAMental_ValueChanged(sender, e);
            numericUpDownCADefending_ValueChanged(sender, e);
            numericUpDownCAAttacking_ValueChanged(sender, e);
        }

        private void numericUpDownMADiscipline_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCAFitness_ValueChanged(sender, e);
            numericUpDownCAGoalkeepers_ValueChanged(sender, e);
            numericUpDownCATactical_ValueChanged(sender, e);
            numericUpDownCATechnical_ValueChanged(sender, e);
            numericUpDownCAMental_ValueChanged(sender, e);
            numericUpDownCADefending_ValueChanged(sender, e);
            numericUpDownCAAttacking_ValueChanged(sender, e);
        }

        private void numericUpDownMAMotivating_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCAFitness_ValueChanged(sender, e);
            numericUpDownCAGoalkeepers_ValueChanged(sender, e);
            numericUpDownCATactical_ValueChanged(sender, e);
            numericUpDownCATechnical_ValueChanged(sender, e);
            numericUpDownCAMental_ValueChanged(sender, e);
            numericUpDownCADefending_ValueChanged(sender, e);
            numericUpDownCAAttacking_ValueChanged(sender, e);
        }

        #endregion

        /****** Functions ******/

        #region Change Language functions

        private void changeLanguage(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentUICulture = ci;
            foreach (ToolStripItem item in menuStrip.Items)
            {
                changeToolStripItemLanguage(item, ci);
            }
            foreach (Control c in this.Controls)
            {
                changeControlLanguage(c, ci);
            }
        }

        private void changeControlLanguage(Control control, CultureInfo ci)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            resources.ApplyResources(control, control.Name, ci);

            if (control.HasChildren)
            {
                foreach (Control controlChil in control.Controls)
                {
                    changeControlLanguage(controlChil, ci);
                }
            }
        }

        private void changeToolStripItemLanguage(ToolStripItem item, CultureInfo ci)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            item.Text = resources.GetString(item.Name + ".Text", ci);

            if (item is ToolStripMenuItem)
            {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)item;

                if (menuItem.HasDropDownItems)
                {
                    foreach (ToolStripItem itemChild in menuItem.DropDownItems)
                    {
                        changeToolStripItemLanguage(itemChild, ci);
                    }
                }
            }
        }

        #endregion

        #region Update Stars functions

        private void updateStars(FlowLayoutPanel flp, float nbs)
        {
            if (flp.HasChildren)
            {
                flp.Controls.Clear();
            }

            // add full stars
            for (int i = 1; i <= nbs; i++)
            {
                PictureBox pbox = new PictureBox();
                pbox.Image = global::FM_Coach.Properties.Resources.glyphicons_049_star;
                pbox.Size = new System.Drawing.Size(30, 30);
                flp.Controls.Add(pbox);
            }
            // add half star if necessary
            int half = (int)(nbs * 2);
            if (half % 2 == 1)
            {
                PictureBox pbox = new PictureBox();
                pbox.Image = global::FM_Coach.Properties.Resources.glyphicons_049_halfstar;
                pbox.Size = new System.Drawing.Size(30, 30);
                flp.Controls.Add(pbox);
            }
        }

        #endregion

    }
}
