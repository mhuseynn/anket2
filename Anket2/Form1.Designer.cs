namespace Anket2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tname = new TextBox();
            tsurname = new TextBox();
            temail = new TextBox();
            tphone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lname = new Label();
            lsurname = new Label();
            lemail = new Label();
            lphone = new Label();
            lbirthday = new Label();
            addbtn = new Button();
            Persons = new ListBox();
            file_name = new TextBox();
            loadbtn = new Button();
            savebtn = new Button();
            editbtn = new Button();
            SuspendLayout();
            // 
            // tname
            // 
            tname.Location = new Point(137, 42);
            tname.Name = "tname";
            tname.Size = new Size(250, 27);
            tname.TabIndex = 0;
            // 
            // tsurname
            // 
            tsurname.Location = new Point(137, 94);
            tsurname.Name = "tsurname";
            tsurname.Size = new Size(250, 27);
            tsurname.TabIndex = 1;
            // 
            // temail
            // 
            temail.Location = new Point(137, 148);
            temail.Name = "temail";
            temail.Size = new Size(250, 27);
            temail.TabIndex = 2;
            // 
            // tphone
            // 
            tphone.Location = new Point(137, 199);
            tphone.Name = "tphone";
            tphone.Size = new Size(250, 27);
            tphone.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 259);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Location = new Point(55, 45);
            lname.Name = "lname";
            lname.Size = new Size(49, 20);
            lname.TabIndex = 6;
            lname.Text = "Name";
            // 
            // lsurname
            // 
            lsurname.AutoSize = true;
            lsurname.Location = new Point(52, 97);
            lsurname.Name = "lsurname";
            lsurname.Size = new Size(67, 20);
            lsurname.TabIndex = 7;
            lsurname.Text = "Surname";
            // 
            // lemail
            // 
            lemail.AutoSize = true;
            lemail.Location = new Point(55, 151);
            lemail.Name = "lemail";
            lemail.Size = new Size(46, 20);
            lemail.TabIndex = 8;
            lemail.Text = "Email";
            // 
            // lphone
            // 
            lphone.AutoSize = true;
            lphone.Location = new Point(54, 202);
            lphone.Name = "lphone";
            lphone.Size = new Size(50, 20);
            lphone.TabIndex = 9;
            lphone.Text = "Phone";
            // 
            // lbirthday
            // 
            lbirthday.AutoSize = true;
            lbirthday.Location = new Point(52, 264);
            lbirthday.Name = "lbirthday";
            lbirthday.Size = new Size(74, 20);
            lbirthday.TabIndex = 10;
            lbirthday.Text = "Birth date";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(282, 342);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(105, 40);
            addbtn.TabIndex = 11;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += add_Click;
            // 
            // Persons
            // 
            Persons.FormattingEnabled = true;
            Persons.ItemHeight = 20;
            Persons.Location = new Point(469, 12);
            Persons.Name = "Persons";
            Persons.Size = new Size(319, 344);
            Persons.TabIndex = 12;
            // 
            // file_name
            // 
            file_name.Location = new Point(469, 373);
            file_name.Name = "file_name";
            file_name.PlaceholderText = "File Name";
            file_name.Size = new Size(319, 27);
            file_name.TabIndex = 13;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(576, 409);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(103, 29);
            loadbtn.TabIndex = 14;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(685, 409);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(103, 29);
            savebtn.TabIndex = 15;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(469, 409);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(101, 29);
            editbtn.TabIndex = 16;
            editbtn.Text = "Edit ";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editbtn);
            Controls.Add(savebtn);
            Controls.Add(loadbtn);
            Controls.Add(file_name);
            Controls.Add(Persons);
            Controls.Add(addbtn);
            Controls.Add(lbirthday);
            Controls.Add(lphone);
            Controls.Add(lemail);
            Controls.Add(lsurname);
            Controls.Add(lname);
            Controls.Add(dateTimePicker1);
            Controls.Add(tphone);
            Controls.Add(temail);
            Controls.Add(tsurname);
            Controls.Add(tname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tname;
        private TextBox tsurname;
        private TextBox temail;
        private TextBox tphone;
        private DateTimePicker dateTimePicker1;
        private Label lname;
        private Label lsurname;
        private Label lemail;
        private Label lphone;
        private Label lbirthday;
        private Button addbtn;
        private ListBox Persons;
        private TextBox file_name;
        private Button loadbtn;
        private Button savebtn;
        private Button editbtn;
    }
}