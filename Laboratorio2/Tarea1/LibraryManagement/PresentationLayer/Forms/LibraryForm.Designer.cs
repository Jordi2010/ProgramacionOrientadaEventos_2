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
            libraryTabControl = new TabControl();
            booksTabPage = new TabPage();
            booksButtonsGroupBox = new GroupBox();
            deleteBookButton = new Button();
            editBookButton = new Button();
            booksDataGridView = new DataGridView();
            adminBooksLabel = new Label();
            booksGroupBox = new GroupBox();
            statusBookComboBox = new ComboBox();
            label1 = new Label();
            authorBookComboBox = new ComboBox();
            saveBookButton = new Button();
            statusBookLabel = new Label();
            genreBookTextBox = new TextBox();
            genreLabel = new Label();
            isbnBookTextBox = new TextBox();
            isbnBookLabel = new Label();
            publisherBookTextBox = new TextBox();
            publisherBookLabel = new Label();
            titleBookTextBox = new TextBox();
            titleBookLabel = new Label();
            loansTabPage = new TabPage();
            loansButtonsGroupBox = new GroupBox();
            deleteLoanButton = new Button();
            editLoanButton = new Button();
            loansDataGridView = new DataGridView();
            adminLoansLabel = new Label();
            loansGroupBox = new GroupBox();
            estimatedReturnDateTimePicker = new DateTimePicker();
            loanDateTimePicker = new DateTimePicker();
            label2 = new Label();
            bookComboBox = new ComboBox();
            loanDateLabel = new Label();
            saveLoanButton = new Button();
            customerTextBox = new TextBox();
            customerLabel = new Label();
            bookLoanLabel = new Label();
            returnsTabPage = new TabPage();
            returnsButtonsGroupBox = new GroupBox();
            deleteReturnButton = new Button();
            editReturnButton = new Button();
            returnsDataGridView = new DataGridView();
            adminReturnsLabel = new Label();
            returnsGroupBox = new GroupBox();
            LoanComboBox = new ComboBox();
            label3 = new Label();
            statusLoanComboBox = new ComboBox();
            actualReturnDateTimePicker = new DateTimePicker();
            actualReturnDateLabel = new Label();
            saveReturnButton = new Button();
            loanLabel = new Label();
            AuthorTabPage = new TabPage();
            label6 = new Label();
            groupBox2 = new GroupBox();
            UpdateAuthorButton = new Button();
            DeleteAuthor = new Button();
            AutoresDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            authorLastNameTextBox = new TextBox();
            SaveAuthorButton = new Button();
            authorFirstNameTextBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            libraryTabControl.SuspendLayout();
            booksTabPage.SuspendLayout();
            booksButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
            booksGroupBox.SuspendLayout();
            loansTabPage.SuspendLayout();
            loansButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loansDataGridView).BeginInit();
            loansGroupBox.SuspendLayout();
            returnsTabPage.SuspendLayout();
            returnsButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnsDataGridView).BeginInit();
            returnsGroupBox.SuspendLayout();
            AuthorTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AutoresDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // libraryTabControl
            // 
            libraryTabControl.Controls.Add(booksTabPage);
            libraryTabControl.Controls.Add(loansTabPage);
            libraryTabControl.Controls.Add(returnsTabPage);
            libraryTabControl.Controls.Add(AuthorTabPage);
            libraryTabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libraryTabControl.Location = new Point(12, 12);
            libraryTabControl.Name = "libraryTabControl";
            libraryTabControl.SelectedIndex = 0;
            libraryTabControl.Size = new Size(839, 527);
            libraryTabControl.TabIndex = 0;
            // 
            // booksTabPage
            // 
            booksTabPage.Controls.Add(booksButtonsGroupBox);
            booksTabPage.Controls.Add(booksDataGridView);
            booksTabPage.Controls.Add(adminBooksLabel);
            booksTabPage.Controls.Add(booksGroupBox);
            booksTabPage.Location = new Point(4, 30);
            booksTabPage.Name = "booksTabPage";
            booksTabPage.Padding = new Padding(3);
            booksTabPage.Size = new Size(831, 493);
            booksTabPage.TabIndex = 0;
            booksTabPage.Text = "Libros";
            booksTabPage.UseVisualStyleBackColor = true;
            // 
            // booksButtonsGroupBox
            // 
            booksButtonsGroupBox.Controls.Add(deleteBookButton);
            booksButtonsGroupBox.Controls.Add(editBookButton);
            booksButtonsGroupBox.Location = new Point(15, 383);
            booksButtonsGroupBox.Name = "booksButtonsGroupBox";
            booksButtonsGroupBox.Size = new Size(424, 93);
            booksButtonsGroupBox.TabIndex = 3;
            booksButtonsGroupBox.TabStop = false;
            // 
            // deleteBookButton
            // 
            deleteBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBookButton.Location = new Point(246, 39);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(85, 32);
            deleteBookButton.TabIndex = 15;
            deleteBookButton.Text = "Eliminar";
            deleteBookButton.UseVisualStyleBackColor = true;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // editBookButton
            // 
            editBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBookButton.Location = new Point(60, 39);
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(85, 32);
            editBookButton.TabIndex = 14;
            editBookButton.Text = "Editar";
            editBookButton.UseVisualStyleBackColor = true;
            editBookButton.Click += editBookButton_Click;
            // 
            // booksDataGridView
            // 
            booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGridView.Location = new Point(15, 48);
            booksDataGridView.Name = "booksDataGridView";
            booksDataGridView.RowTemplate.Height = 25;
            booksDataGridView.Size = new Size(424, 329);
            booksDataGridView.TabIndex = 2;
            // 
            // adminBooksLabel
            // 
            adminBooksLabel.AutoSize = true;
            adminBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminBooksLabel.Location = new Point(299, 17);
            adminBooksLabel.Name = "adminBooksLabel";
            adminBooksLabel.Size = new Size(197, 21);
            adminBooksLabel.TabIndex = 1;
            adminBooksLabel.Text = "Administración de libros";
            // 
            // booksGroupBox
            // 
            booksGroupBox.Controls.Add(statusBookComboBox);
            booksGroupBox.Controls.Add(label1);
            booksGroupBox.Controls.Add(authorBookComboBox);
            booksGroupBox.Controls.Add(saveBookButton);
            booksGroupBox.Controls.Add(statusBookLabel);
            booksGroupBox.Controls.Add(genreBookTextBox);
            booksGroupBox.Controls.Add(genreLabel);
            booksGroupBox.Controls.Add(isbnBookTextBox);
            booksGroupBox.Controls.Add(isbnBookLabel);
            booksGroupBox.Controls.Add(publisherBookTextBox);
            booksGroupBox.Controls.Add(publisherBookLabel);
            booksGroupBox.Controls.Add(titleBookTextBox);
            booksGroupBox.Controls.Add(titleBookLabel);
            booksGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            booksGroupBox.Location = new Point(456, 48);
            booksGroupBox.Name = "booksGroupBox";
            booksGroupBox.Size = new Size(360, 428);
            booksGroupBox.TabIndex = 0;
            booksGroupBox.TabStop = false;
            // 
            // statusBookComboBox
            // 
            statusBookComboBox.FormattingEnabled = true;
            statusBookComboBox.Location = new Point(86, 232);
            statusBookComboBox.Name = "statusBookComboBox";
            statusBookComboBox.Size = new Size(256, 25);
            statusBookComboBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 73);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 15;
            label1.Text = "Autor:";
            // 
            // authorBookComboBox
            // 
            authorBookComboBox.FormattingEnabled = true;
            authorBookComboBox.Location = new Point(86, 65);
            authorBookComboBox.Name = "authorBookComboBox";
            authorBookComboBox.Size = new Size(256, 25);
            authorBookComboBox.TabIndex = 14;
            // 
            // saveBookButton
            // 
            saveBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBookButton.Location = new Point(152, 348);
            saveBookButton.Name = "saveBookButton";
            saveBookButton.Size = new Size(85, 32);
            saveBookButton.TabIndex = 13;
            saveBookButton.Text = "Guardar";
            saveBookButton.UseVisualStyleBackColor = true;
            saveBookButton.Click += saveBookButton_Click;
            // 
            // statusBookLabel
            // 
            statusBookLabel.AutoSize = true;
            statusBookLabel.Location = new Point(15, 235);
            statusBookLabel.Name = "statusBookLabel";
            statusBookLabel.Size = new Size(51, 17);
            statusBookLabel.TabIndex = 10;
            statusBookLabel.Text = "Estado:";
            // 
            // genreBookTextBox
            // 
            genreBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            genreBookTextBox.Location = new Point(86, 189);
            genreBookTextBox.Name = "genreBookTextBox";
            genreBookTextBox.PlaceholderText = "ciencia ficción postapocalíptica";
            genreBookTextBox.Size = new Size(256, 25);
            genreBookTextBox.TabIndex = 9;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(15, 193);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(54, 17);
            genreLabel.TabIndex = 8;
            genreLabel.Text = "Género:";
            // 
            // isbnBookTextBox
            // 
            isbnBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            isbnBookTextBox.Location = new Point(86, 149);
            isbnBookTextBox.Name = "isbnBookTextBox";
            isbnBookTextBox.PlaceholderText = "978-0-306-40615-7";
            isbnBookTextBox.Size = new Size(256, 25);
            isbnBookTextBox.TabIndex = 7;
            // 
            // isbnBookLabel
            // 
            isbnBookLabel.AutoSize = true;
            isbnBookLabel.Location = new Point(15, 153);
            isbnBookLabel.Name = "isbnBookLabel";
            isbnBookLabel.Size = new Size(38, 17);
            isbnBookLabel.TabIndex = 6;
            isbnBookLabel.Text = "ISBN:";
            // 
            // publisherBookTextBox
            // 
            publisherBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            publisherBookTextBox.Location = new Point(86, 109);
            publisherBookTextBox.Name = "publisherBookTextBox";
            publisherBookTextBox.PlaceholderText = "Eksmo";
            publisherBookTextBox.Size = new Size(256, 25);
            publisherBookTextBox.TabIndex = 5;
            // 
            // publisherBookLabel
            // 
            publisherBookLabel.AutoSize = true;
            publisherBookLabel.Location = new Point(15, 114);
            publisherBookLabel.Name = "publisherBookLabel";
            publisherBookLabel.Size = new Size(59, 17);
            publisherBookLabel.TabIndex = 4;
            publisherBookLabel.Text = "Editorial:";
            // 
            // titleBookTextBox
            // 
            titleBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleBookTextBox.Location = new Point(86, 23);
            titleBookTextBox.Name = "titleBookTextBox";
            titleBookTextBox.PlaceholderText = "Metro 2033";
            titleBookTextBox.Size = new Size(256, 25);
            titleBookTextBox.TabIndex = 1;
            // 
            // titleBookLabel
            // 
            titleBookLabel.AutoSize = true;
            titleBookLabel.Location = new Point(15, 28);
            titleBookLabel.Name = "titleBookLabel";
            titleBookLabel.Size = new Size(43, 17);
            titleBookLabel.TabIndex = 0;
            titleBookLabel.Text = "Título:";
            // 
            // loansTabPage
            // 
            loansTabPage.Controls.Add(loansButtonsGroupBox);
            loansTabPage.Controls.Add(loansDataGridView);
            loansTabPage.Controls.Add(adminLoansLabel);
            loansTabPage.Controls.Add(loansGroupBox);
            loansTabPage.Location = new Point(4, 30);
            loansTabPage.Name = "loansTabPage";
            loansTabPage.Padding = new Padding(3);
            loansTabPage.Size = new Size(831, 493);
            loansTabPage.TabIndex = 1;
            loansTabPage.Text = "Préstamos";
            loansTabPage.UseVisualStyleBackColor = true;
            // 
            // loansButtonsGroupBox
            // 
            loansButtonsGroupBox.Controls.Add(deleteLoanButton);
            loansButtonsGroupBox.Controls.Add(editLoanButton);
            loansButtonsGroupBox.Location = new Point(15, 383);
            loansButtonsGroupBox.Name = "loansButtonsGroupBox";
            loansButtonsGroupBox.Size = new Size(424, 93);
            loansButtonsGroupBox.TabIndex = 7;
            loansButtonsGroupBox.TabStop = false;
            // 
            // deleteLoanButton
            // 
            deleteLoanButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteLoanButton.Location = new Point(246, 39);
            deleteLoanButton.Name = "deleteLoanButton";
            deleteLoanButton.Size = new Size(85, 32);
            deleteLoanButton.TabIndex = 15;
            deleteLoanButton.Text = "Eliminar";
            deleteLoanButton.UseVisualStyleBackColor = true;
            // 
            // editLoanButton
            // 
            editLoanButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editLoanButton.Location = new Point(81, 39);
            editLoanButton.Name = "editLoanButton";
            editLoanButton.Size = new Size(85, 32);
            editLoanButton.TabIndex = 14;
            editLoanButton.Text = "Editar";
            editLoanButton.UseVisualStyleBackColor = true;
            // 
            // loansDataGridView
            // 
            loansDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loansDataGridView.Location = new Point(15, 48);
            loansDataGridView.Name = "loansDataGridView";
            loansDataGridView.RowTemplate.Height = 25;
            loansDataGridView.Size = new Size(424, 329);
            loansDataGridView.TabIndex = 6;
            // 
            // adminLoansLabel
            // 
            adminLoansLabel.AutoSize = true;
            adminLoansLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminLoansLabel.Location = new Point(299, 17);
            adminLoansLabel.Name = "adminLoansLabel";
            adminLoansLabel.Size = new Size(233, 21);
            adminLoansLabel.TabIndex = 5;
            adminLoansLabel.Text = "Administración de préstamos";
            // 
            // loansGroupBox
            // 
            loansGroupBox.Controls.Add(estimatedReturnDateTimePicker);
            loansGroupBox.Controls.Add(loanDateTimePicker);
            loansGroupBox.Controls.Add(label2);
            loansGroupBox.Controls.Add(bookComboBox);
            loansGroupBox.Controls.Add(loanDateLabel);
            loansGroupBox.Controls.Add(saveLoanButton);
            loansGroupBox.Controls.Add(customerTextBox);
            loansGroupBox.Controls.Add(customerLabel);
            loansGroupBox.Controls.Add(bookLoanLabel);
            loansGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loansGroupBox.Location = new Point(456, 48);
            loansGroupBox.Name = "loansGroupBox";
            loansGroupBox.Size = new Size(360, 428);
            loansGroupBox.TabIndex = 4;
            loansGroupBox.TabStop = false;
            // 
            // estimatedReturnDateTimePicker
            // 
            estimatedReturnDateTimePicker.Location = new Point(6, 264);
            estimatedReturnDateTimePicker.Name = "estimatedReturnDateTimePicker";
            estimatedReturnDateTimePicker.Size = new Size(256, 25);
            estimatedReturnDateTimePicker.TabIndex = 20;
            // 
            // loanDateTimePicker
            // 
            loanDateTimePicker.Location = new Point(6, 182);
            loanDateTimePicker.Name = "loanDateTimePicker";
            loanDateTimePicker.Size = new Size(256, 25);
            loanDateTimePicker.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 231);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 17;
            label2.Text = "Fecha de devolucion esperada:";
            // 
            // bookComboBox
            // 
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(80, 38);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(256, 25);
            bookComboBox.TabIndex = 16;
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanDateLabel.Location = new Point(6, 150);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new Size(138, 20);
            loanDateLabel.TabIndex = 14;
            loanDateLabel.Text = "Fecha de préstamo:";
            // 
            // saveLoanButton
            // 
            saveLoanButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveLoanButton.Location = new Point(141, 354);
            saveLoanButton.Name = "saveLoanButton";
            saveLoanButton.Size = new Size(85, 32);
            saveLoanButton.TabIndex = 13;
            saveLoanButton.Text = "Guardar";
            saveLoanButton.UseVisualStyleBackColor = true;
            // 
            // customerTextBox
            // 
            customerTextBox.BorderStyle = BorderStyle.FixedSingle;
            customerTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerTextBox.Location = new Point(80, 92);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.PlaceholderText = "Andrew lauttner";
            customerTextBox.Size = new Size(256, 27);
            customerTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerLabel.Location = new Point(6, 94);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(58, 20);
            customerLabel.TabIndex = 2;
            customerLabel.Text = "Cliente:";
            // 
            // bookLoanLabel
            // 
            bookLoanLabel.AutoSize = true;
            bookLoanLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookLoanLabel.Location = new Point(6, 38);
            bookLoanLabel.Name = "bookLoanLabel";
            bookLoanLabel.Size = new Size(46, 20);
            bookLoanLabel.TabIndex = 0;
            bookLoanLabel.Text = "Libro:";
            // 
            // returnsTabPage
            // 
            returnsTabPage.Controls.Add(returnsButtonsGroupBox);
            returnsTabPage.Controls.Add(returnsDataGridView);
            returnsTabPage.Controls.Add(adminReturnsLabel);
            returnsTabPage.Controls.Add(returnsGroupBox);
            returnsTabPage.Location = new Point(4, 30);
            returnsTabPage.Name = "returnsTabPage";
            returnsTabPage.Padding = new Padding(3);
            returnsTabPage.Size = new Size(831, 493);
            returnsTabPage.TabIndex = 2;
            returnsTabPage.Text = "Devoluciones";
            returnsTabPage.UseVisualStyleBackColor = true;
            // 
            // returnsButtonsGroupBox
            // 
            returnsButtonsGroupBox.Controls.Add(deleteReturnButton);
            returnsButtonsGroupBox.Controls.Add(editReturnButton);
            returnsButtonsGroupBox.Location = new Point(15, 383);
            returnsButtonsGroupBox.Name = "returnsButtonsGroupBox";
            returnsButtonsGroupBox.Size = new Size(424, 93);
            returnsButtonsGroupBox.TabIndex = 11;
            returnsButtonsGroupBox.TabStop = false;
            // 
            // deleteReturnButton
            // 
            deleteReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteReturnButton.Location = new Point(246, 39);
            deleteReturnButton.Name = "deleteReturnButton";
            deleteReturnButton.Size = new Size(85, 32);
            deleteReturnButton.TabIndex = 15;
            deleteReturnButton.Text = "Eliminar";
            deleteReturnButton.UseVisualStyleBackColor = true;
            // 
            // editReturnButton
            // 
            editReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editReturnButton.Location = new Point(81, 39);
            editReturnButton.Name = "editReturnButton";
            editReturnButton.Size = new Size(85, 32);
            editReturnButton.TabIndex = 14;
            editReturnButton.Text = "Editar";
            editReturnButton.UseVisualStyleBackColor = true;
            // 
            // returnsDataGridView
            // 
            returnsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnsDataGridView.Location = new Point(15, 48);
            returnsDataGridView.Name = "returnsDataGridView";
            returnsDataGridView.RowTemplate.Height = 25;
            returnsDataGridView.Size = new Size(424, 329);
            returnsDataGridView.TabIndex = 10;
            // 
            // adminReturnsLabel
            // 
            adminReturnsLabel.AutoSize = true;
            adminReturnsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminReturnsLabel.Location = new Point(299, 17);
            adminReturnsLabel.Name = "adminReturnsLabel";
            adminReturnsLabel.Size = new Size(256, 21);
            adminReturnsLabel.TabIndex = 9;
            adminReturnsLabel.Text = "Administración de devoluciones";
            // 
            // returnsGroupBox
            // 
            returnsGroupBox.Controls.Add(LoanComboBox);
            returnsGroupBox.Controls.Add(label3);
            returnsGroupBox.Controls.Add(statusLoanComboBox);
            returnsGroupBox.Controls.Add(actualReturnDateTimePicker);
            returnsGroupBox.Controls.Add(actualReturnDateLabel);
            returnsGroupBox.Controls.Add(saveReturnButton);
            returnsGroupBox.Controls.Add(loanLabel);
            returnsGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnsGroupBox.Location = new Point(456, 48);
            returnsGroupBox.Name = "returnsGroupBox";
            returnsGroupBox.Size = new Size(360, 428);
            returnsGroupBox.TabIndex = 8;
            returnsGroupBox.TabStop = false;
            // 
            // LoanComboBox
            // 
            LoanComboBox.FormattingEnabled = true;
            LoanComboBox.Location = new Point(92, 34);
            LoanComboBox.Name = "LoanComboBox";
            LoanComboBox.Size = new Size(255, 25);
            LoanComboBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 175);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 18;
            label3.Text = "Estado de prestamo";
            // 
            // statusLoanComboBox
            // 
            statusLoanComboBox.FormattingEnabled = true;
            statusLoanComboBox.Location = new Point(6, 212);
            statusLoanComboBox.Name = "statusLoanComboBox";
            statusLoanComboBox.Size = new Size(256, 25);
            statusLoanComboBox.TabIndex = 17;
            // 
            // actualReturnDateTimePicker
            // 
            actualReturnDateTimePicker.Location = new Point(6, 125);
            actualReturnDateTimePicker.Name = "actualReturnDateTimePicker";
            actualReturnDateTimePicker.Size = new Size(255, 25);
            actualReturnDateTimePicker.TabIndex = 16;
            // 
            // actualReturnDateLabel
            // 
            actualReturnDateLabel.AutoSize = true;
            actualReturnDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            actualReturnDateLabel.Location = new Point(6, 90);
            actualReturnDateLabel.Name = "actualReturnDateLabel";
            actualReturnDateLabel.Size = new Size(177, 20);
            actualReturnDateLabel.TabIndex = 14;
            actualReturnDateLabel.Text = "Fecha de devolución real:";
            // 
            // saveReturnButton
            // 
            saveReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveReturnButton.Location = new Point(141, 354);
            saveReturnButton.Name = "saveReturnButton";
            saveReturnButton.Size = new Size(85, 32);
            saveReturnButton.TabIndex = 13;
            saveReturnButton.Text = "Guardar";
            saveReturnButton.UseVisualStyleBackColor = true;
            // 
            // loanLabel
            // 
            loanLabel.AutoSize = true;
            loanLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanLabel.Location = new Point(6, 34);
            loanLabel.Name = "loanLabel";
            loanLabel.Size = new Size(74, 20);
            loanLabel.TabIndex = 0;
            loanLabel.Text = "Préstamo:";
            // 
            // AuthorTabPage
            // 
            AuthorTabPage.Controls.Add(label6);
            AuthorTabPage.Controls.Add(groupBox2);
            AuthorTabPage.Controls.Add(AutoresDataGridView);
            AuthorTabPage.Controls.Add(groupBox1);
            AuthorTabPage.Location = new Point(4, 30);
            AuthorTabPage.Name = "AuthorTabPage";
            AuthorTabPage.Padding = new Padding(3);
            AuthorTabPage.Size = new Size(831, 493);
            AuthorTabPage.TabIndex = 3;
            AuthorTabPage.Text = "Autores";
            AuthorTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(286, 17);
            label6.Name = "label6";
            label6.Size = new Size(211, 21);
            label6.TabIndex = 10;
            label6.Text = "Administración de autores";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UpdateAuthorButton);
            groupBox2.Controls.Add(DeleteAuthor);
            groupBox2.Location = new Point(6, 385);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 93);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // UpdateAuthorButton
            // 
            UpdateAuthorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateAuthorButton.Location = new Point(32, 39);
            UpdateAuthorButton.Name = "UpdateAuthorButton";
            UpdateAuthorButton.Size = new Size(85, 32);
            UpdateAuthorButton.TabIndex = 16;
            UpdateAuthorButton.Text = "Editar";
            UpdateAuthorButton.UseVisualStyleBackColor = true;
            UpdateAuthorButton.Click += UpdateAuthorButton_Click;
            // 
            // DeleteAuthor
            // 
            DeleteAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAuthor.Location = new Point(246, 39);
            DeleteAuthor.Name = "DeleteAuthor";
            DeleteAuthor.Size = new Size(85, 32);
            DeleteAuthor.TabIndex = 15;
            DeleteAuthor.Text = "Eliminar";
            DeleteAuthor.UseVisualStyleBackColor = true;
            DeleteAuthor.Click += DeleteAuthor_Click;
            // 
            // AutoresDataGridView
            // 
            AutoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AutoresDataGridView.Location = new Point(6, 50);
            AutoresDataGridView.Name = "AutoresDataGridView";
            AutoresDataGridView.RowTemplate.Height = 25;
            AutoresDataGridView.Size = new Size(424, 329);
            AutoresDataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(authorLastNameTextBox);
            groupBox1.Controls.Add(SaveAuthorButton);
            groupBox1.Controls.Add(authorFirstNameTextBox);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(465, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 329);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 93);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 17;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 37);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 16;
            label4.Text = "Nombre";
            // 
            // authorLastNameTextBox
            // 
            authorLastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorLastNameTextBox.Location = new Point(77, 93);
            authorLastNameTextBox.Name = "authorLastNameTextBox";
            authorLastNameTextBox.PlaceholderText = "Glukhovsky";
            authorLastNameTextBox.Size = new Size(256, 25);
            authorLastNameTextBox.TabIndex = 15;
            // 
            // SaveAuthorButton
            // 
            SaveAuthorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveAuthorButton.Location = new Point(132, 278);
            SaveAuthorButton.Name = "SaveAuthorButton";
            SaveAuthorButton.Size = new Size(85, 32);
            SaveAuthorButton.TabIndex = 13;
            SaveAuthorButton.Text = "Guardar";
            SaveAuthorButton.UseVisualStyleBackColor = true;
            SaveAuthorButton.Click += SaveAuthorButton_Click;
            // 
            // authorFirstNameTextBox
            // 
            authorFirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorFirstNameTextBox.Location = new Point(77, 35);
            authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            authorFirstNameTextBox.PlaceholderText = "Dmitry";
            authorFirstNameTextBox.Size = new Size(256, 25);
            authorFirstNameTextBox.TabIndex = 14;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 551);
            Controls.Add(libraryTabControl);
            Name = "LibraryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibraryForm";
            libraryTabControl.ResumeLayout(false);
            booksTabPage.ResumeLayout(false);
            booksTabPage.PerformLayout();
            booksButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).EndInit();
            booksGroupBox.ResumeLayout(false);
            booksGroupBox.PerformLayout();
            loansTabPage.ResumeLayout(false);
            loansTabPage.PerformLayout();
            loansButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loansDataGridView).EndInit();
            loansGroupBox.ResumeLayout(false);
            loansGroupBox.PerformLayout();
            returnsTabPage.ResumeLayout(false);
            returnsTabPage.PerformLayout();
            returnsButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)returnsDataGridView).EndInit();
            returnsGroupBox.ResumeLayout(false);
            returnsGroupBox.PerformLayout();
            AuthorTabPage.ResumeLayout(false);
            AuthorTabPage.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AutoresDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
    }
}