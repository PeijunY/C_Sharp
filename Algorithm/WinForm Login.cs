	private void button1_Click(object sender, EventArgs e)
        {
            //判断用户名是否输入
            if (this.txtUserName.Text.Trim().Length==0)
            {
                MessageBox.Show("用户名不能为空", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus(); //让鼠标停留在这里
                return;
            }
            //判断密码是否输入
            if (this.txtUserPasswd.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserPasswd.Focus(); //让鼠标停留在这里
                return;
            }
            //判断账号密码是否正确
            if (this.txtUserName.Text.Trim() == "Admin" && this.txtUserPasswd.Text == "123456")
            {
                MessageBox.Show("恭喜你，登录成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("登录失败！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }