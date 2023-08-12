using System;
using System.Windows.Forms;

namespace graphics3
{
    public partial class Form1 : Form
    {
        GraphObject curr;
        Pyramid pyr = new Pyramid(200, 200, 0, 100, 150);
        BiezSurface surf;

        public Form1()
        {
            InitializeComponent();
            listBox_Direction.SelectedIndex = 0;

            curr = pyr;
            //
            point3D[] tp = 
            {
            new point3D(100, 100, 0), new point3D(120, 100, 0), new point3D(140, 100, 0), new point3D(160, 100, 0),
            new point3D(100, 150, 0),new point3D(120, 150, 0),new point3D(140, 150, 0),new point3D(160, 150, 0),
            new point3D(100, 200, 0),new point3D(120, 200, 0),new point3D(140, 200, 0),new point3D(160, 200, 0),
            new point3D(100, 250, 0),new point3D(120, 250, 0),new point3D(140, 250, 0),new point3D(160, 250, 0)
            
            /*new point3D(100, 100, 0), new point3D(100, 200, 0), new point3D(0, 0, 0), new point3D(0, 0, 0),
            new point3D(250, 100, 0), new point3D(250, 200, 0),new point3D(0, 0, 0),new point3D(0, 0, 0),
            new point3D(0, 0, 0),new point3D(0, 0, 0),new point3D(0, 0, 0),new point3D(0, 0, 0),
            new point3D(0, 0, 0),new point3D(0, 0, 0),new point3D(0, 0, 0),new point3D(0, 0, 0)*/

            };
            surf = new BiezSurface(tp);
            comboBox_Figure.SelectedIndex = 0;
            comboBoxM.SelectedIndex = 0;
            comboBoxN.SelectedIndex = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            projType[] projs = { projType.front, projType.left, projType.above, projType.dimetry, projType.isometry };
            curr.draw(e.Graphics, projs[listBox_Direction.SelectedIndex], checkBox_Hide.Checked);
            curr.drawAxes(e.Graphics, projs[listBox_Direction.SelectedIndex]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button1_RotateX_Click(object sender, EventArgs e)
        {
            if (checkBox1_X.Checked)
                curr.rotate(10, axe.ox);
            if (checkBox2_Y.Checked)
                curr.rotate(10, axe.oy);
            if (checkBox3_Z.Checked)
                curr.rotate(10, axe.oz);
            pictureBox1.Refresh();
        }

        private void button2_RotateMinus_Click(object sender, EventArgs e)
        {
            if (checkBox1_X.Checked)
                curr.rotate(-10, axe.ox);
            if (checkBox2_Y.Checked)
                curr.rotate(-10, axe.oy);
            if (checkBox3_Z.Checked)
                curr.rotate(-10, axe.oz);
            pictureBox1.Refresh();
        }

        private void button3_MovePlus_Click(object sender, EventArgs e)
        {
            curr.move(checkBox1_X.Checked ? 30 : 0, checkBox2_Y.Checked ? 30 : 0, checkBox3_Z.Checked ? 30 : 0);
            
            pictureBox1.Refresh();
        }

        private void button4_MoveMinus_Click(object sender, EventArgs e)
        {
            curr.move(checkBox1_X.Checked ? -30 : 0, checkBox2_Y.Checked ? -30 : 0, checkBox3_Z.Checked ? -30 : 0);
            pictureBox1.Refresh();
        }

        private void button5_ScalePlus_Click(object sender, EventArgs e)
        {
            curr.scale(checkBox1_X.Checked ? 1.5 : 1, checkBox2_Y.Checked ? 1.5 : 1, checkBox3_Z.Checked ? 1.5 : 1);
            pictureBox1.Refresh();
        }

        private void button6_ScaleMinus_Click(object sender, EventArgs e)
        {
            curr.scale(checkBox1_X.Checked ? 1 / 1.5 : 1, 
                checkBox2_Y.Checked ? 1 / 1.5 : 1, 
                checkBox3_Z.Checked ? 1 / 1.5 : 1);
            pictureBox1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Figure.SelectedIndex == 0)
                curr = pyr;
            else
                curr = surf;
            pictureBox1.Refresh();

            panel1.Visible = comboBox_Figure.SelectedIndex != 0;
            button_SetChanges.Visible = comboBox_Figure.SelectedIndex != 0;
        }

        private void comboBoxN_SelectedIndexChanged(object sender, EventArgs e)
        {
            point3D p = surf.points[int.Parse(comboBoxN.Text)*4 + int.Parse(comboBoxM.Text)];
            textBoxX.Text = p.x.ToString();
            textBoxY.Text = p.y.ToString();
            textBoxZ.Text = p.z.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point3D p;
            p.x = double.Parse(textBoxX.Text);
            p.y = double.Parse(textBoxY.Text);
            p.z = double.Parse(textBoxZ.Text);

            surf.points[int.Parse(comboBoxN.Text) * 4 + int.Parse(comboBoxM.Text)] = p;

            pictureBox1.Refresh();
        }
    }
}

/* BUTTON 3, 4 - second variant
//if (checkBox1_X.Checked)
            //    pyr.move2(10, axe.ox);
            //if (checkBox2_Y.Checked)
            //    pyr.move2(10, axe.oy);
            //if (checkBox3_Z.Checked)
            //    pyr.move2(10, axe.oz);
 */