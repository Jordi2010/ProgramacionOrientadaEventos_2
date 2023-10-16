namespace PresentationLayer.Forms
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.libraryTabControl = new System.Windows.Forms.TabControl();
            this.booksTabPage = new System.Windows.Forms.TabPage();
            this.booksButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.editBookButton = new System.Windows.Forms.Button();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.adminBooksLabel = new System.Windows.Forms.Label();
            this.booksGroupBox = new System.Windows.Forms.GroupBox();
            this.statusBookComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorBookComboBox = new System.Windows.Forms.ComboBox();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.statusBookLabel = new System.Windows.Forms.Label();
            this.genreBookTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.isbnBookTextBox = new System.Windows.Forms.TextBox();
            this.isbnBookLabel = new System.Windows.Forms.Label();
            this.publisherBookTextBox = new System.Windows.Forms.TextBox();
            this.publisherBookLabel = new System.Windows.Forms.Label();
            this.titleBookTextBox = new System.Windows.Forms.TextBox();
            this.titleBookLabel = new System.Windows.Forms.Label();
            this.loansTabPage = new System.Windows.Forms.TabPage();
            this.loansButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteLoanButton = new System.Windows.Forms.Button();
            this.editLoanButton = new System.Windows.Forms.Button();
            this.loansDataGridView = new System.Windows.Forms.DataGridView();
            this.adminLoansLabel = new System.Windows.Forms.Label();
            this.loansGroupBox = new System.Windows.Forms.GroupBox();
            this.estimatedReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.loanDateLabel = new System.Windows.Forms.Label();
            this.saveLoanButton = new System.Windows.Forms.Button();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.bookLoanLabel = new System.Windows.Forms.Label();
            this.returnsTabPage = new System.Windows.Forms.TabPage();
            this.returnsButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteReturnButton = new System.Windows.Forms.Button();
            this.editReturnButton = new System.Windows.Forms.Button();
            this.returnsDataGridView = new System.Windows.Forms.DataGridView();
            this.adminReturnsLabel = new System.Windows.Forms.Label();
            this.returnsGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.returnBookComboBox = new System.Windows.Forms.ComboBox();
            this.LoanComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLoanComboBox = new System.Windows.Forms.ComboBox();
            this.actualReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualReturnDateLabel = new System.Windows.Forms.Label();
            this.saveReturnButton = new System.Windows.Forms.Button();
            this.loanLabel = new System.Windows.Forms.Label();
            this.AuthorTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateAuthorButton = new System.Windows.Forms.Button();
            this.DeleteAuthor = new System.Windows.Forms.Button();
            this.AutoresDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveAuthorButton = new System.Windows.Forms.Button();
            this.authorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.libraryTabControl.SuspendLayout();
            this.booksTabPage.SuspendLayout();
            this.booksButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.booksGroupBox.SuspendLayout();
            this.loansTabPage.SuspendLayout();
            this.loansButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).BeginInit();
            this.loansGroupBox.SuspendLayout();
            this.returnsTabPage.SuspendLayout();
            this.returnsButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnsDataGridView)).BeginInit();
            this.returnsGroupBox.SuspendLayout();
            this.AuthorTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoresDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryTabControl
            // 
            this.libraryTabControl.Controls.Add(this.booksTabPage);
            this.libraryTabControl.Controls.Add(this.loansTabPage);
            this.libraryTabControl.Controls.Add(this.returnsTabPage);
            this.libraryTabControl.Controls.Add(this.AuthorTabPage);
            this.libraryTabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.libraryTabControl.Location = new System.Drawing.Point(12, 12);
            this.libraryTabControl.Name = "libraryTabControl";
            this.libraryTabControl.SelectedIndex = 0;
            this.libraryTabControl.Size = new System.Drawing.Size(839, 527);
            this.libraryTabControl.TabIndex = 0;
            // 
            // booksTabPage
            // 
            this.booksTabPage.Controls.Add(this.booksButtonsGroupBox);
            this.booksTabPage.Controls.Add(this.booksDataGridView);
            this.booksTabPage.Controls.Add(this.adminBooksLabel);
            this.booksTabPage.Controls.Add(this.booksGroupBox);
            this.booksTabPage.Location = new System.Drawing.Point(4, 30);
            this.booksTabPage.Name = "booksTabPage";
            this.booksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.booksTabPage.Size = new System.Drawing.Size(831, 493);
            this.booksTabPage.TabIndex = 0;
            this.booksTabPage.Text = "Libros";
            this.booksTabPage.UseVisualStyleBackColor = true;
            // 
            // booksButtonsGroupBox
            // 
            this.booksButtonsGroupBox.Controls.Add(this.deleteBookButton);
            this.booksButtonsGroupBox.Controls.Add(this.editBookButton);
            this.booksButtonsGroupBox.Location = new System.Drawing.Point(15, 383);
            this.booksButtonsGroupBox.Name = "booksButtonsGroupBox";
            this.booksButtonsGroupBox.Size = new System.Drawing.Size(424, 93);
            this.booksButtonsGroupBox.TabIndex = 3;
            this.booksButtonsGroupBox.TabStop = false;
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBookButton.Location = new System.Drawing.Point(246, 39);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(85, 32);
            this.deleteBookButton.TabIndex = 15;
            this.deleteBookButton.Text = "Eliminar";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // editBookButton
            // 
            this.editBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBookButton.Location = new System.Drawing.Point(60, 39);
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(85, 32);
            this.editBookButton.TabIndex = 14;
            this.editBookButton.Text = "Editar";
            this.editBookButton.UseVisualStyleBackColor = true;
            this.editBookButton.Click += new System.EventHandler(this.editBookButton_Click);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(15, 48);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowTemplate.Height = 25;
            this.booksDataGridView.Size = new System.Drawing.Size(424, 329);
            this.booksDataGridView.TabIndex = 2;
            // 
            // adminBooksLabel
            // 
            this.adminBooksLabel.AutoSize = true;
            this.adminBooksLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminBooksLabel.Location = new System.Drawing.Point(299, 17);
            this.adminBooksLabel.Name = "adminBooksLabel";
            this.adminBooksLabel.Size = new System.Drawing.Size(197, 21);
            this.adminBooksLabel.TabIndex = 1;
            this.adminBooksLabel.Text = "Administración de libros";
            // 
            // booksGroupBox
            // 
            this.booksGroupBox.Controls.Add(this.statusBookComboBox);
            this.booksGroupBox.Controls.Add(this.label1);
            this.booksGroupBox.Controls.Add(this.authorBookComboBox);
            this.booksGroupBox.Controls.Add(this.saveBookButton);
            this.booksGroupBox.Controls.Add(this.statusBookLabel);
            this.booksGroupBox.Controls.Add(this.genreBookTextBox);
            this.booksGroupBox.Controls.Add(this.genreLabel);
            this.booksGroupBox.Controls.Add(this.isbnBookTextBox);
            this.booksGroupBox.Controls.Add(this.isbnBookLabel);
            this.booksGroupBox.Controls.Add(this.publisherBookTextBox);
            this.booksGroupBox.Controls.Add(this.publisherBookLabel);
            this.booksGroupBox.Controls.Add(this.titleBookTextBox);
            this.booksGroupBox.Controls.Add(this.titleBookLabel);
            this.booksGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booksGroupBox.Location = new System.Drawing.Point(456, 48);
            this.booksGroupBox.Name = "booksGroupBox";
            this.booksGroupBox.Size = new System.Drawing.Size(360, 428);
            this.booksGroupBox.TabIndex = 0;
            this.booksGroupBox.TabStop = false;
            // 
            // statusBookComboBox
            // 
            this.statusBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBookComboBox.FormattingEnabled = true;
            this.statusBookComboBox.Location = new System.Drawing.Point(86, 232);
            this.statusBookComboBox.Name = "statusBookComboBox";
            this.statusBookComboBox.Size = new System.Drawing.Size(256, 25);
            this.statusBookComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Autor:";
            // 
            // authorBookComboBox
            // 
            this.authorBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorBookComboBox.FormattingEnabled = true;
            this.authorBookComboBox.Location = new System.Drawing.Point(86, 65);
            this.authorBookComboBox.Name = "authorBookComboBox";
            this.authorBookComboBox.Size = new System.Drawing.Size(256, 25);
            this.authorBookComboBox.TabIndex = 14;
            // 
            // saveBookButton
            // 
            this.saveBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBookButton.Location = new System.Drawing.Point(152, 348);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(85, 32);
            this.saveBookButton.TabIndex = 13;
            this.saveBookButton.Text = "Guardar";
            this.saveBookButton.UseVisualStyleBackColor = true;
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);
            // 
            // statusBookLabel
            // 
            this.statusBookLabel.AutoSize = true;
            this.statusBookLabel.Location = new System.Drawing.Point(15, 235);
            this.statusBookLabel.Name = "statusBookLabel";
            this.statusBookLabel.Size = new System.Drawing.Size(51, 17);
            this.statusBookLabel.TabIndex = 10;
            this.statusBookLabel.Text = "Estado:";
            // 
            // genreBookTextBox
            // 
            this.genreBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreBookTextBox.Location = new System.Drawing.Point(86, 189);
            this.genreBookTextBox.Name = "genreBookTextBox";
            this.genreBookTextBox.PlaceholderText = "ciencia ficción postapocalíptica";
            this.genreBookTextBox.Size = new System.Drawing.Size(256, 25);
            this.genreBookTextBox.TabIndex = 9;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(15, 193);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(54, 17);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Género:";
            // 
            // isbnBookTextBox
            // 
            this.isbnBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isbnBookTextBox.Location = new System.Drawing.Point(86, 149);
            this.isbnBookTextBox.Name = "isbnBookTextBox";
            this.isbnBookTextBox.PlaceholderText = "978-0-306-40615-7";
            this.isbnBookTextBox.Size = new System.Drawing.Size(256, 25);
            this.isbnBookTextBox.TabIndex = 7;
            // 
            // isbnBookLabel
            // 
            this.isbnBookLabel.AutoSize = true;
            this.isbnBookLabel.Location = new System.Drawing.Point(15, 153);
            this.isbnBookLabel.Name = "isbnBookLabel";
            this.isbnBookLabel.Size = new System.Drawing.Size(38, 17);
            this.isbnBookLabel.TabIndex = 6;
            this.isbnBookLabel.Text = "ISBN:";
            // 
            // publisherBookTextBox
            // 
            this.publisherBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.publisherBookTextBox.Location = new System.Drawing.Point(86, 109);
            this.publisherBookTextBox.Name = "publisherBookTextBox";
            this.publisherBookTextBox.PlaceholderText = "Eksmo";
            this.publisherBookTextBox.Size = new System.Drawing.Size(256, 25);
            this.publisherBookTextBox.TabIndex = 5;
            // 
            // publisherBookLabel
            // 
            this.publisherBookLabel.AutoSize = true;
            this.publisherBookLabel.Location = new System.Drawing.Point(15, 114);
            this.publisherBookLabel.Name = "publisherBookLabel";
            this.publisherBookLabel.Size = new System.Drawing.Size(59, 17);
            this.publisherBookLabel.TabIndex = 4;
            this.publisherBookLabel.Text = "Editorial:";
            // 
            // titleBookTextBox
            // 
            this.titleBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBookTextBox.Location = new System.Drawing.Point(86, 23);
            this.titleBookTextBox.Name = "titleBookTextBox";
            this.titleBookTextBox.PlaceholderText = "Metro 2033";
            this.titleBookTextBox.Size = new System.Drawing.Size(256, 25);
            this.titleBookTextBox.TabIndex = 1;
            // 
            // titleBookLabel
            // 
            this.titleBookLabel.AutoSize = true;
            this.titleBookLabel.Location = new System.Drawing.Point(15, 28);
            this.titleBookLabel.Name = "titleBookLabel";
            this.titleBookLabel.Size = new System.Drawing.Size(43, 17);
            this.titleBookLabel.TabIndex = 0;
            this.titleBookLabel.Text = "Título:";
            // 
            // loansTabPage
            // 
            this.loansTabPage.Controls.Add(this.loansButtonsGroupBox);
            this.loansTabPage.Controls.Add(this.loansDataGridView);
            this.loansTabPage.Controls.Add(this.adminLoansLabel);
            this.loansTabPage.Controls.Add(this.loansGroupBox);
            this.loansTabPage.Location = new System.Drawing.Point(4, 30);
            this.loansTabPage.Name = "loansTabPage";
            this.loansTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loansTabPage.Size = new System.Drawing.Size(831, 493);
            this.loansTabPage.TabIndex = 1;
            this.loansTabPage.Text = "Préstamos";
            this.loansTabPage.UseVisualStyleBackColor = true;
            // 
            // loansButtonsGroupBox
            // 
            this.loansButtonsGroupBox.Controls.Add(this.deleteLoanButton);
            this.loansButtonsGroupBox.Controls.Add(this.editLoanButton);
            this.loansButtonsGroupBox.Location = new System.Drawing.Point(15, 383);
            this.loansButtonsGroupBox.Name = "loansButtonsGroupBox";
            this.loansButtonsGroupBox.Size = new System.Drawing.Size(424, 93);
            this.loansButtonsGroupBox.TabIndex = 7;
            this.loansButtonsGroupBox.TabStop = false;
            // 
            // deleteLoanButton
            // 
            this.deleteLoanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteLoanButton.Location = new System.Drawing.Point(246, 39);
            this.deleteLoanButton.Name = "deleteLoanButton";
            this.deleteLoanButton.Size = new System.Drawing.Size(85, 32);
            this.deleteLoanButton.TabIndex = 15;
            this.deleteLoanButton.Text = "Eliminar";
            this.deleteLoanButton.UseVisualStyleBackColor = true;
            this.deleteLoanButton.Click += new System.EventHandler(this.deleteLoanButton_Click);
            // 
            // editLoanButton
            // 
            this.editLoanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editLoanButton.Location = new System.Drawing.Point(81, 39);
            this.editLoanButton.Name = "editLoanButton";
            this.editLoanButton.Size = new System.Drawing.Size(85, 32);
            this.editLoanButton.TabIndex = 14;
            this.editLoanButton.Text = "Editar";
            this.editLoanButton.UseVisualStyleBackColor = true;
            this.editLoanButton.Click += new System.EventHandler(this.editLoanButton_Click);
            // 
            // loansDataGridView
            // 
            this.loansDataGridView.AllowUserToAddRows = false;
            this.loansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loansDataGridView.Location = new System.Drawing.Point(15, 48);
            this.loansDataGridView.Name = "loansDataGridView";
            this.loansDataGridView.RowTemplate.Height = 25;
            this.loansDataGridView.Size = new System.Drawing.Size(424, 329);
            this.loansDataGridView.TabIndex = 6;
            // 
            // adminLoansLabel
            // 
            this.adminLoansLabel.AutoSize = true;
            this.adminLoansLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminLoansLabel.Location = new System.Drawing.Point(299, 17);
            this.adminLoansLabel.Name = "adminLoansLabel";
            this.adminLoansLabel.Size = new System.Drawing.Size(233, 21);
            this.adminLoansLabel.TabIndex = 5;
            this.adminLoansLabel.Text = "Administración de préstamos";
            // 
            // loansGroupBox
            // 
            this.loansGroupBox.Controls.Add(this.estimatedReturnDateTimePicker);
            this.loansGroupBox.Controls.Add(this.loanDateTimePicker);
            this.loansGroupBox.Controls.Add(this.label2);
            this.loansGroupBox.Controls.Add(this.bookComboBox);
            this.loansGroupBox.Controls.Add(this.loanDateLabel);
            this.loansGroupBox.Controls.Add(this.saveLoanButton);
            this.loansGroupBox.Controls.Add(this.customerTextBox);
            this.loansGroupBox.Controls.Add(this.customerLabel);
            this.loansGroupBox.Controls.Add(this.bookLoanLabel);
            this.loansGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loansGroupBox.Location = new System.Drawing.Point(456, 48);
            this.loansGroupBox.Name = "loansGroupBox";
            this.loansGroupBox.Size = new System.Drawing.Size(360, 428);
            this.loansGroupBox.TabIndex = 4;
            this.loansGroupBox.TabStop = false;
            // 
            // estimatedReturnDateTimePicker
            // 
            this.estimatedReturnDateTimePicker.Location = new System.Drawing.Point(6, 264);
            this.estimatedReturnDateTimePicker.Name = "estimatedReturnDateTimePicker";
            this.estimatedReturnDateTimePicker.Size = new System.Drawing.Size(256, 25);
            this.estimatedReturnDateTimePicker.TabIndex = 20;
            this.estimatedReturnDateTimePicker.Value = new System.DateTime(2023, 10, 15, 0, 0, 0, 0);
            // 
            // loanDateTimePicker
            // 
            this.loanDateTimePicker.Location = new System.Drawing.Point(6, 182);
            this.loanDateTimePicker.Name = "loanDateTimePicker";
            this.loanDateTimePicker.Size = new System.Drawing.Size(256, 25);
            this.loanDateTimePicker.TabIndex = 19;
            this.loanDateTimePicker.Value = new System.DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de devolucion esperada:";
            // 
            // bookComboBox
            // 
            this.bookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(80, 38);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(256, 25);
            this.bookComboBox.TabIndex = 16;
            // 
            // loanDateLabel
            // 
            this.loanDateLabel.AutoSize = true;
            this.loanDateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanDateLabel.Location = new System.Drawing.Point(6, 150);
            this.loanDateLabel.Name = "loanDateLabel";
            this.loanDateLabel.Size = new System.Drawing.Size(138, 20);
            this.loanDateLabel.TabIndex = 14;
            this.loanDateLabel.Text = "Fecha de préstamo:";
            // 
            // saveLoanButton
            // 
            this.saveLoanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveLoanButton.Location = new System.Drawing.Point(141, 354);
            this.saveLoanButton.Name = "saveLoanButton";
            this.saveLoanButton.Size = new System.Drawing.Size(85, 32);
            this.saveLoanButton.TabIndex = 13;
            this.saveLoanButton.Text = "Guardar";
            this.saveLoanButton.UseVisualStyleBackColor = true;
            this.saveLoanButton.Click += new System.EventHandler(this.saveLoanButton_Click);
            // 
            // customerTextBox
            // 
            this.customerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerTextBox.Location = new System.Drawing.Point(80, 92);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.PlaceholderText = "Andrew lauttner";
            this.customerTextBox.Size = new System.Drawing.Size(256, 27);
            this.customerTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerLabel.Location = new System.Drawing.Point(6, 94);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(58, 20);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Cliente:";
            // 
            // bookLoanLabel
            // 
            this.bookLoanLabel.AutoSize = true;
            this.bookLoanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookLoanLabel.Location = new System.Drawing.Point(6, 38);
            this.bookLoanLabel.Name = "bookLoanLabel";
            this.bookLoanLabel.Size = new System.Drawing.Size(46, 20);
            this.bookLoanLabel.TabIndex = 0;
            this.bookLoanLabel.Text = "Libro:";
            // 
            // returnsTabPage
            // 
            this.returnsTabPage.Controls.Add(this.returnsButtonsGroupBox);
            this.returnsTabPage.Controls.Add(this.returnsDataGridView);
            this.returnsTabPage.Controls.Add(this.adminReturnsLabel);
            this.returnsTabPage.Controls.Add(this.returnsGroupBox);
            this.returnsTabPage.Location = new System.Drawing.Point(4, 30);
            this.returnsTabPage.Name = "returnsTabPage";
            this.returnsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.returnsTabPage.Size = new System.Drawing.Size(831, 493);
            this.returnsTabPage.TabIndex = 2;
            this.returnsTabPage.Text = "Devoluciones";
            this.returnsTabPage.UseVisualStyleBackColor = true;
            // 
            // returnsButtonsGroupBox
            // 
            this.returnsButtonsGroupBox.Controls.Add(this.deleteReturnButton);
            this.returnsButtonsGroupBox.Controls.Add(this.editReturnButton);
            this.returnsButtonsGroupBox.Location = new System.Drawing.Point(15, 383);
            this.returnsButtonsGroupBox.Name = "returnsButtonsGroupBox";
            this.returnsButtonsGroupBox.Size = new System.Drawing.Size(424, 93);
            this.returnsButtonsGroupBox.TabIndex = 11;
            this.returnsButtonsGroupBox.TabStop = false;
            // 
            // deleteReturnButton
            // 
            this.deleteReturnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteReturnButton.Location = new System.Drawing.Point(246, 39);
            this.deleteReturnButton.Name = "deleteReturnButton";
            this.deleteReturnButton.Size = new System.Drawing.Size(85, 32);
            this.deleteReturnButton.TabIndex = 15;
            this.deleteReturnButton.Text = "Eliminar";
            this.deleteReturnButton.UseVisualStyleBackColor = true;
            this.deleteReturnButton.Click += new System.EventHandler(this.deleteReturnButton_Click);
            // 
            // editReturnButton
            // 
            this.editReturnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editReturnButton.Location = new System.Drawing.Point(81, 39);
            this.editReturnButton.Name = "editReturnButton";
            this.editReturnButton.Size = new System.Drawing.Size(85, 32);
            this.editReturnButton.TabIndex = 14;
            this.editReturnButton.Text = "Editar";
            this.editReturnButton.UseVisualStyleBackColor = true;
            this.editReturnButton.Click += new System.EventHandler(this.editReturnButton_Click);
            // 
            // returnsDataGridView
            // 
            this.returnsDataGridView.AllowUserToAddRows = false;
            this.returnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnsDataGridView.Location = new System.Drawing.Point(15, 48);
            this.returnsDataGridView.Name = "returnsDataGridView";
            this.returnsDataGridView.RowTemplate.Height = 25;
            this.returnsDataGridView.Size = new System.Drawing.Size(424, 329);
            this.returnsDataGridView.TabIndex = 10;
            // 
            // adminReturnsLabel
            // 
            this.adminReturnsLabel.AutoSize = true;
            this.adminReturnsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminReturnsLabel.Location = new System.Drawing.Point(299, 17);
            this.adminReturnsLabel.Name = "adminReturnsLabel";
            this.adminReturnsLabel.Size = new System.Drawing.Size(256, 21);
            this.adminReturnsLabel.TabIndex = 9;
            this.adminReturnsLabel.Text = "Administración de devoluciones";
            // 
            // returnsGroupBox
            // 
            this.returnsGroupBox.Controls.Add(this.label7);
            this.returnsGroupBox.Controls.Add(this.returnBookComboBox);
            this.returnsGroupBox.Controls.Add(this.LoanComboBox);
            this.returnsGroupBox.Controls.Add(this.label3);
            this.returnsGroupBox.Controls.Add(this.statusLoanComboBox);
            this.returnsGroupBox.Controls.Add(this.actualReturnDateTimePicker);
            this.returnsGroupBox.Controls.Add(this.actualReturnDateLabel);
            this.returnsGroupBox.Controls.Add(this.saveReturnButton);
            this.returnsGroupBox.Controls.Add(this.loanLabel);
            this.returnsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnsGroupBox.Location = new System.Drawing.Point(456, 48);
            this.returnsGroupBox.Name = "returnsGroupBox";
            this.returnsGroupBox.Size = new System.Drawing.Size(360, 428);
            this.returnsGroupBox.TabIndex = 8;
            this.returnsGroupBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estado del libro";
            // 
            // returnBookComboBox
            // 
            this.returnBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.returnBookComboBox.FormattingEnabled = true;
            this.returnBookComboBox.Location = new System.Drawing.Point(6, 293);
            this.returnBookComboBox.Name = "returnBookComboBox";
            this.returnBookComboBox.Size = new System.Drawing.Size(256, 25);
            this.returnBookComboBox.TabIndex = 20;
            // 
            // LoanComboBox
            // 
            this.LoanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoanComboBox.FormattingEnabled = true;
            this.LoanComboBox.Location = new System.Drawing.Point(92, 34);
            this.LoanComboBox.Name = "LoanComboBox";
            this.LoanComboBox.Size = new System.Drawing.Size(255, 25);
            this.LoanComboBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado de prestamo";
            // 
            // statusLoanComboBox
            // 
            this.statusLoanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusLoanComboBox.FormattingEnabled = true;
            this.statusLoanComboBox.Location = new System.Drawing.Point(6, 212);
            this.statusLoanComboBox.Name = "statusLoanComboBox";
            this.statusLoanComboBox.Size = new System.Drawing.Size(256, 25);
            this.statusLoanComboBox.TabIndex = 17;
            // 
            // actualReturnDateTimePicker
            // 
            this.actualReturnDateTimePicker.Location = new System.Drawing.Point(6, 125);
            this.actualReturnDateTimePicker.Name = "actualReturnDateTimePicker";
            this.actualReturnDateTimePicker.Size = new System.Drawing.Size(255, 25);
            this.actualReturnDateTimePicker.TabIndex = 16;
            // 
            // actualReturnDateLabel
            // 
            this.actualReturnDateLabel.AutoSize = true;
            this.actualReturnDateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actualReturnDateLabel.Location = new System.Drawing.Point(6, 90);
            this.actualReturnDateLabel.Name = "actualReturnDateLabel";
            this.actualReturnDateLabel.Size = new System.Drawing.Size(177, 20);
            this.actualReturnDateLabel.TabIndex = 14;
            this.actualReturnDateLabel.Text = "Fecha de devolución real:";
            // 
            // saveReturnButton
            // 
            this.saveReturnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveReturnButton.Location = new System.Drawing.Point(141, 354);
            this.saveReturnButton.Name = "saveReturnButton";
            this.saveReturnButton.Size = new System.Drawing.Size(85, 32);
            this.saveReturnButton.TabIndex = 13;
            this.saveReturnButton.Text = "Guardar";
            this.saveReturnButton.UseVisualStyleBackColor = true;
            this.saveReturnButton.Click += new System.EventHandler(this.saveReturnButton_Click);
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanLabel.Location = new System.Drawing.Point(6, 34);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(74, 20);
            this.loanLabel.TabIndex = 0;
            this.loanLabel.Text = "Préstamo:";
            // 
            // AuthorTabPage
            // 
            this.AuthorTabPage.Controls.Add(this.label6);
            this.AuthorTabPage.Controls.Add(this.groupBox2);
            this.AuthorTabPage.Controls.Add(this.AutoresDataGridView);
            this.AuthorTabPage.Controls.Add(this.groupBox1);
            this.AuthorTabPage.Location = new System.Drawing.Point(4, 30);
            this.AuthorTabPage.Name = "AuthorTabPage";
            this.AuthorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorTabPage.Size = new System.Drawing.Size(831, 493);
            this.AuthorTabPage.TabIndex = 3;
            this.AuthorTabPage.Text = "Autores";
            this.AuthorTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(286, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Administración de autores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateAuthorButton);
            this.groupBox2.Controls.Add(this.DeleteAuthor);
            this.groupBox2.Location = new System.Drawing.Point(6, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // UpdateAuthorButton
            // 
            this.UpdateAuthorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateAuthorButton.Location = new System.Drawing.Point(32, 39);
            this.UpdateAuthorButton.Name = "UpdateAuthorButton";
            this.UpdateAuthorButton.Size = new System.Drawing.Size(85, 32);
            this.UpdateAuthorButton.TabIndex = 16;
            this.UpdateAuthorButton.Text = "Editar";
            this.UpdateAuthorButton.UseVisualStyleBackColor = true;
            this.UpdateAuthorButton.Click += new System.EventHandler(this.UpdateAuthorButton_Click);
            // 
            // DeleteAuthor
            // 
            this.DeleteAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAuthor.Location = new System.Drawing.Point(246, 39);
            this.DeleteAuthor.Name = "DeleteAuthor";
            this.DeleteAuthor.Size = new System.Drawing.Size(85, 32);
            this.DeleteAuthor.TabIndex = 15;
            this.DeleteAuthor.Text = "Eliminar";
            this.DeleteAuthor.UseVisualStyleBackColor = true;
            this.DeleteAuthor.Click += new System.EventHandler(this.DeleteAuthor_Click);
            // 
            // AutoresDataGridView
            // 
            this.AutoresDataGridView.AllowUserToAddRows = false;
            this.AutoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoresDataGridView.Location = new System.Drawing.Point(6, 50);
            this.AutoresDataGridView.Name = "AutoresDataGridView";
            this.AutoresDataGridView.RowTemplate.Height = 25;
            this.AutoresDataGridView.Size = new System.Drawing.Size(424, 329);
            this.AutoresDataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.authorLastNameTextBox);
            this.groupBox1.Controls.Add(this.SaveAuthorButton);
            this.groupBox1.Controls.Add(this.authorFirstNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(465, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // authorLastNameTextBox
            // 
            this.authorLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorLastNameTextBox.Location = new System.Drawing.Point(77, 93);
            this.authorLastNameTextBox.Name = "authorLastNameTextBox";
            this.authorLastNameTextBox.PlaceholderText = "Glukhovsky";
            this.authorLastNameTextBox.Size = new System.Drawing.Size(256, 25);
            this.authorLastNameTextBox.TabIndex = 15;
            // 
            // SaveAuthorButton
            // 
            this.SaveAuthorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveAuthorButton.Location = new System.Drawing.Point(132, 278);
            this.SaveAuthorButton.Name = "SaveAuthorButton";
            this.SaveAuthorButton.Size = new System.Drawing.Size(85, 32);
            this.SaveAuthorButton.TabIndex = 13;
            this.SaveAuthorButton.Text = "Guardar";
            this.SaveAuthorButton.UseVisualStyleBackColor = true;
            this.SaveAuthorButton.Click += new System.EventHandler(this.SaveAuthorButton_Click);
            // 
            // authorFirstNameTextBox
            // 
            this.authorFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorFirstNameTextBox.Location = new System.Drawing.Point(77, 35);
            this.authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            this.authorFirstNameTextBox.PlaceholderText = "Dmitry";
            this.authorFirstNameTextBox.Size = new System.Drawing.Size(256, 25);
            this.authorFirstNameTextBox.TabIndex = 14;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 551);
            this.Controls.Add(this.libraryTabControl);
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryForm";
            this.libraryTabControl.ResumeLayout(false);
            this.booksTabPage.ResumeLayout(false);
            this.booksTabPage.PerformLayout();
            this.booksButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.booksGroupBox.ResumeLayout(false);
            this.booksGroupBox.PerformLayout();
            this.loansTabPage.ResumeLayout(false);
            this.loansTabPage.PerformLayout();
            this.loansButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).EndInit();
            this.loansGroupBox.ResumeLayout(false);
            this.loansGroupBox.PerformLayout();
            this.returnsTabPage.ResumeLayout(false);
            this.returnsTabPage.PerformLayout();
            this.returnsButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnsDataGridView)).EndInit();
            this.returnsGroupBox.ResumeLayout(false);
            this.returnsGroupBox.PerformLayout();
            this.AuthorTabPage.ResumeLayout(false);
            this.AuthorTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoresDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl libraryTabControl;
        private TabPage booksTabPage;
        private TabPage loansTabPage;
        private TabPage returnsTabPage;
        private GroupBox booksGroupBox;
        private Label adminBooksLabel;
        private GroupBox booksButtonsGroupBox;
        private DataGridView booksDataGridView;
        private TextBox titleBookTextBox;
        private Label titleBookLabel;
        private Label statusBookLabel;
        private TextBox genreBookTextBox;
        private Label genreLabel;
        private TextBox isbnBookTextBox;
        private Label isbnBookLabel;
        private TextBox publisherBookTextBox;
        private Label publisherBookLabel;
        private Button deleteBookButton;
        private Button editBookButton;
        private Button saveBookButton;
        private GroupBox loansButtonsGroupBox;
        private Button deleteLoanButton;
        private Button editLoanButton;
        private DataGridView loansDataGridView;
        private Label adminLoansLabel;
        private GroupBox loansGroupBox;
        private Button saveLoanButton;
        private TextBox customerTextBox;
        private Label customerLabel;
        private Label bookLoanLabel;
        private Label loanDateLabel;
        private GroupBox returnsButtonsGroupBox;
        private Button deleteReturnButton;
        private Button editReturnButton;
        private DataGridView returnsDataGridView;
        private Label adminReturnsLabel;
        private GroupBox returnsGroupBox;
        private Label actualReturnDateLabel;
        private Button saveReturnButton;
        private Label loanLabel;
        private Label label1;
        private ComboBox authorBookComboBox;
        private DateTimePicker estimatedReturnDateTimePicker;
        private DateTimePicker loanDateTimePicker;
        private Label label2;
        private ComboBox bookComboBox;
        private TabPage AuthorTabPage;
        private GroupBox groupBox2;
        private Button DeleteAuthor;
        private DataGridView AutoresDataGridView;
        private GroupBox groupBox1;
        private TextBox authorLastNameTextBox;
        private Button SaveAuthorButton;
        private TextBox authorFirstNameTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox statusBookComboBox;
        private ComboBox LoanComboBox;
        private Label label3;
        private ComboBox statusLoanComboBox;
        private DateTimePicker actualReturnDateTimePicker;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button UpdateAuthorButton;
        private Label label7;
        private ComboBox returnBookComboBox;
    }
}