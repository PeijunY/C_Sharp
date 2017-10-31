 private void SetColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SetColor.SelectedItem == "红色")
            {
                this.Describe.BackColor = Color.Red;
                return;
            }
            else if (this.SetColor.SelectedItem == "黄色")
            {
                this.Describe.BackColor = Color.Yellow;
                return;
            }
            else if (this.SetColor.SelectedItem == "黑色")
            {
                this.Describe.BackColor = Color.Black;
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Describe.BackColor = Color.White;
            this.Describe.ForeColor = Color.Black;
            this.SetColor.Text = "请选择颜色";
        }