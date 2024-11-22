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

        public void SetReview(int s, string b, DateTime rd)
        {
            Score = $"Score: {s}/10";
            Body = b;
            ReviewDate = rd.ToString("MMM dd, yyyy");
        }
    }
}
