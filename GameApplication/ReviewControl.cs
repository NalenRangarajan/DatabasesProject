using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApplication
{
    public partial class ReviewControl : UserControl
    {
        public ReviewControl()
        {
            InitializeComponent();
        }

        public string Score
        {
            get
            {
                return ScoreLabel.Text;
            }
            set
            {
                ScoreLabel.Text = value;
            }
        }

        public string Title
        {
            get
            {
                return TitleLabel.Text;
            }
            set
            {
                TitleLabel.Text = value;
            }
        }

        public string Body
        {
            get
            {
                return BodyLabel.Text;
            }
            set
            {
                BodyLabel.Text = value;
            }
        }

        public string ReviewDate
        {
            get
            {
                return ReviewDateLabel.Text;
            }
            set
            {
                ReviewDateLabel.Text = value;
            }
        }

        public void SetReview(int s, string t, string b, DateTime rd)
        {
            ScoreLabel.Text = $"Score: {s}/10";
            TitleLabel.Text = t;
            BodyLabel.Text = b;
            ReviewDateLabel.Text = rd.ToString("MMM dd, yyyy");
        }
    }
}
