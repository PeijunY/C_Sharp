	private void button1_Click(object sender, EventArgs e)
        {
            //�ж��û����Ƿ�����
            if (this.txtUserName.Text.Trim().Length==0)
            {
                MessageBox.Show("�û�������Ϊ��", "ϵͳ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus(); //�����ͣ��������
                return;
            }
            //�ж������Ƿ�����
            if (this.txtUserPasswd.Text.Length == 0)
            {
                MessageBox.Show("���벻��Ϊ��", "ϵͳ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserPasswd.Focus(); //�����ͣ��������
                return;
            }
            //�ж��˺������Ƿ���ȷ
            if (this.txtUserName.Text.Trim() == "Admin" && this.txtUserPasswd.Text == "123456")
            {
                MessageBox.Show("��ϲ�㣬��¼�ɹ���", "ϵͳ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("��¼ʧ�ܣ�", "ϵͳ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }