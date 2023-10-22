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
            searchBookTextBox = new TextBox();
            label7 = new Label();
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
            returnsDataGridView = new DataGridView();
            adminReturnsLabel = new Label();
            returnsGroupBox = new GroupBox();
            labelClientName = new Label();
            labelLoanClient = new Label();
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
            libraryTabControl.Location = new Point(14, 16);
            libraryTabControl.Margin = new Padding(3, 4, 3, 4);
            libraryTabControl.Name = "libraryTabControl";
            libraryTabControl.SelectedIndex = 0;
            libraryTabControl.Size = new Size(959, 703);
            libraryTabControl.TabIndex = 0;
            // 
            // booksTabPage
            // 
            booksTabPage.Controls.Add(searchBookTextBox);
            booksTabPage.Controls.Add(label7);
            booksTabPage.Controls.Add(booksButtonsGroupBox);
            booksTabPage.Controls.Add(booksDataGridView);
            booksTabPage.Controls.Add(adminBooksLabel);
            booksTabPage.Controls.Add(booksGroupBox);
            booksTabPage.Location = new Point(4, 37);
            booksTabPage.Margin = new Padding(3, 4, 3, 4);
            booksTabPage.Name = "booksTabPage";
            booksTabPage.Padding = new Padding(3, 4, 3, 4);
            booksTabPage.Size = new Size(951, 662);
            booksTabPage.TabIndex = 0;
            booksTabPage.Text = "Libros";
            booksTabPage.UseVisualStyleBackColor = true;
            // 
            // searchBookTextBox
            // 
            searchBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchBookTextBox.Location = new Point(17, 44);
            searchBookTextBox.Name = "searchBookTextBox";
            searchBookTextBox.Size = new Size(335, 34);
            searchBookTextBox.TabIndex = 5;
            searchBookTextBox.TextChanged += searchBookTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 13);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 4;
            label7.Text = "Buscar";
            // 
            // booksButtonsGroupBox
            // 
            booksButtonsGroupBox.Controls.Add(deleteBookButton);
            booksButtonsGroupBox.Controls.Add(editBookButton);
            booksButtonsGroupBox.Location = new Point(17, 511);
            booksButtonsGroupBox.Margin = new Padding(3, 4, 3, 4);
            booksButtonsGroupBox.Name = "booksButtonsGroupBox";
            booksButtonsGroupBox.Padding = new Padding(3, 4, 3, 4);
            booksButtonsGroupBox.Size = new Size(485, 124);
            booksButtonsGroupBox.TabIndex = 3;
            booksButtonsGroupBox.TabStop = false;
            // 
            // deleteBookButton
            // 
            deleteBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBookButton.Location = new Point(281, 52);
            deleteBookButton.Margin = new Padding(3, 4, 3, 4);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(106, 43);
            deleteBookButton.TabIndex = 15;
            deleteBookButton.Text = "Eliminar";
            deleteBookButton.UseVisualStyleBackColor = true;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // editBookButton
            // 
            editBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBookButton.Location = new Point(69, 52);
            editBookButton.Margin = new Padding(3, 4, 3, 4);
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(97, 43);
            editBookButton.TabIndex = 14;
            editBookButton.Text = "Editar";
            editBookButton.UseVisualStyleBackColor = true;
            editBookButton.Click += editBookButton_Click;
            // 
            // booksDataGridView
            // 
            booksDataGridView.AllowUserToAddRows = false;
            booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGridView.Location = new Point(17, 85);
            booksDataGridView.Margin = new Padding(3, 4, 3, 4);
            booksDataGridView.Name = "booksDataGridView";
            booksDataGridView.RowHeadersWidth = 51;
            booksDataGridView.RowTemplate.Height = 25;
            booksDataGridView.Size = new Size(485, 439);
            booksDataGridView.TabIndex = 2;
            // 
            // adminBooksLabel
            // 
            adminBooksLabel.AutoSize = true;
            adminBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminBooksLabel.Location = new Point(345, 4);
            adminBooksLabel.Name = "adminBooksLabel";
            adminBooksLabel.Size = new Size(244, 28);
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
            booksGroupBox.Location = new Point(521, 64);
            booksGroupBox.Margin = new Padding(3, 4, 3, 4);
            booksGroupBox.Name = "booksGroupBox";
            booksGroupBox.Padding = new Padding(3, 4, 3, 4);
            booksGroupBox.Size = new Size(411, 571);
            booksGroupBox.TabIndex = 0;
            booksGroupBox.TabStop = false;
            // 
            // statusBookComboBox
            // 
            statusBookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBookComboBox.FormattingEnabled = true;
            statusBookComboBox.Location = new Point(98, 309);
            statusBookComboBox.Margin = new Padding(3, 4, 3, 4);
            statusBookComboBox.Name = "statusBookComboBox";
            statusBookComboBox.Size = new Size(292, 29);
            statusBookComboBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 97);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 15;
            label1.Text = "Autor:";
            // 
            // authorBookComboBox
            // 
            authorBookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            authorBookComboBox.FormattingEnabled = true;
            authorBookComboBox.Location = new Point(98, 87);
            authorBookComboBox.Margin = new Padding(3, 4, 3, 4);
            authorBookComboBox.Name = "authorBookComboBox";
            authorBookComboBox.Size = new Size(292, 29);
            authorBookComboBox.TabIndex = 14;
            // 
            // saveBookButton
            // 
            saveBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBookButton.Location = new Point(174, 464);
            saveBookButton.Margin = new Padding(3, 4, 3, 4);
            saveBookButton.Name = "saveBookButton";
            saveBookButton.Size = new Size(97, 43);
            saveBookButton.TabIndex = 13;
            saveBookButton.Text = "Guardar";
            saveBookButton.UseVisualStyleBackColor = true;
            saveBookButton.Click += saveBookButton_Click;
            // 
            // statusBookLabel
            // 
            statusBookLabel.AutoSize = true;
            statusBookLabel.Location = new Point(17, 313);
            statusBookLabel.Name = "statusBookLabel";
            statusBookLabel.Size = new Size(65, 23);
            statusBookLabel.TabIndex = 10;
            statusBookLabel.Text = "Estado:";
            // 
            // genreBookTextBox
            // 
            genreBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            genreBookTextBox.Location = new Point(98, 252);
            genreBookTextBox.Margin = new Padding(3, 4, 3, 4);
            genreBookTextBox.Name = "genreBookTextBox";
            genreBookTextBox.PlaceholderText = "ciencia ficción postapocalíptica";
            genreBookTextBox.Size = new Size(292, 29);
            genreBookTextBox.TabIndex = 9;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(17, 257);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(70, 23);
            genreLabel.TabIndex = 8;
            genreLabel.Text = "Género:";
            // 
            // isbnBookTextBox
            // 
            isbnBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            isbnBookTextBox.Location = new Point(98, 199);
            isbnBookTextBox.Margin = new Padding(3, 4, 3, 4);
            isbnBookTextBox.Name = "isbnBookTextBox";
            isbnBookTextBox.PlaceholderText = "978-0-306-40615-7";
            isbnBookTextBox.Size = new Size(292, 29);
            isbnBookTextBox.TabIndex = 7;
            // 
            // isbnBookLabel
            // 
            isbnBookLabel.AutoSize = true;
            isbnBookLabel.Location = new Point(17, 204);
            isbnBookLabel.Name = "isbnBookLabel";
            isbnBookLabel.Size = new Size(51, 23);
            isbnBookLabel.TabIndex = 6;
            isbnBookLabel.Text = "ISBN:";
            // 
            // publisherBookTextBox
            // 
            publisherBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            publisherBookTextBox.Location = new Point(98, 145);
            publisherBookTextBox.Margin = new Padding(3, 4, 3, 4);
            publisherBookTextBox.Name = "publisherBookTextBox";
            publisherBookTextBox.PlaceholderText = "Eksmo";
            publisherBookTextBox.Size = new Size(292, 29);
            publisherBookTextBox.TabIndex = 5;
            // 
            // publisherBookLabel
            // 
            publisherBookLabel.AutoSize = true;
            publisherBookLabel.Location = new Point(17, 152);
            publisherBookLabel.Name = "publisherBookLabel";
            publisherBookLabel.Size = new Size(76, 23);
            publisherBookLabel.TabIndex = 4;
            publisherBookLabel.Text = "Editorial:";
            // 
            // titleBookTextBox
            // 
            titleBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleBookTextBox.Location = new Point(98, 31);
            titleBookTextBox.Margin = new Padding(3, 4, 3, 4);
            titleBookTextBox.Name = "titleBookTextBox";
            titleBookTextBox.PlaceholderText = "Metro 2033";
            titleBookTextBox.Size = new Size(292, 29);
            titleBookTextBox.TabIndex = 1;
            // 
            // titleBookLabel
            // 
            titleBookLabel.AutoSize = true;
            titleBookLabel.Location = new Point(17, 37);
            titleBookLabel.Name = "titleBookLabel";
            titleBookLabel.Size = new Size(57, 23);
            titleBookLabel.TabIndex = 0;
            titleBookLabel.Text = "Título:";
            // 
            // loansTabPage
            // 
            loansTabPage.Controls.Add(loansButtonsGroupBox);
            loansTabPage.Controls.Add(loansDataGridView);
            loansTabPage.Controls.Add(adminLoansLabel);
            loansTabPage.Controls.Add(loansGroupBox);
            loansTabPage.Location = new Point(4, 37);
            loansTabPage.Margin = new Padding(3, 4, 3, 4);
            loansTabPage.Name = "loansTabPage";
            loansTabPage.Padding = new Padding(3, 4, 3, 4);
            loansTabPage.Size = new Size(951, 662);
            loansTabPage.TabIndex = 1;
            loansTabPage.Text = "Préstamos";
            loansTabPage.UseVisualStyleBackColor = true;
            // 
            // loansButtonsGroupBox
            // 
            loansButtonsGroupBox.Controls.Add(deleteLoanButton);
            loansButtonsGroupBox.Location = new Point(17, 511);
            loansButtonsGroupBox.Margin = new Padding(3, 4, 3, 4);
            loansButtonsGroupBox.Name = "loansButtonsGroupBox";
            loansButtonsGroupBox.Padding = new Padding(3, 4, 3, 4);
            loansButtonsGroupBox.Size = new Size(485, 124);
            loansButtonsGroupBox.TabIndex = 7;
            loansButtonsGroupBox.TabStop = false;
            // 
            // deleteLoanButton
            // 
            deleteLoanButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteLoanButton.Location = new Point(281, 52);
            deleteLoanButton.Margin = new Padding(3, 4, 3, 4);
            deleteLoanButton.Name = "deleteLoanButton";
            deleteLoanButton.Size = new Size(104, 43);
            deleteLoanButton.TabIndex = 15;
            deleteLoanButton.Text = "Eliminar";
            deleteLoanButton.UseVisualStyleBackColor = true;
            deleteLoanButton.Click += deleteLoanButton_Click;
            // 
            // loansDataGridView
            // 
            loansDataGridView.AllowUserToAddRows = false;
            loansDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loansDataGridView.Location = new Point(17, 64);
            loansDataGridView.Margin = new Padding(3, 4, 3, 4);
            loansDataGridView.Name = "loansDataGridView";
            loansDataGridView.RowHeadersWidth = 51;
            loansDataGridView.RowTemplate.Height = 25;
            loansDataGridView.Size = new Size(485, 439);
            loansDataGridView.TabIndex = 6;
            // 
            // adminLoansLabel
            // 
            adminLoansLabel.AutoSize = true;
            adminLoansLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminLoansLabel.Location = new Point(342, 23);
            adminLoansLabel.Name = "adminLoansLabel";
            adminLoansLabel.Size = new Size(289, 28);
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
            loansGroupBox.Location = new Point(521, 64);
            loansGroupBox.Margin = new Padding(3, 4, 3, 4);
            loansGroupBox.Name = "loansGroupBox";
            loansGroupBox.Padding = new Padding(3, 4, 3, 4);
            loansGroupBox.Size = new Size(411, 571);
            loansGroupBox.TabIndex = 4;
            loansGroupBox.TabStop = false;
            // 
            // estimatedReturnDateTimePicker
            // 
            estimatedReturnDateTimePicker.Location = new Point(7, 352);
            estimatedReturnDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            estimatedReturnDateTimePicker.Name = "estimatedReturnDateTimePicker";
            estimatedReturnDateTimePicker.Size = new Size(292, 29);
            estimatedReturnDateTimePicker.TabIndex = 20;
            estimatedReturnDateTimePicker.Value = new DateTime(2023, 10, 15, 0, 0, 0, 0);
            // 
            // loanDateTimePicker
            // 
            loanDateTimePicker.Location = new Point(7, 243);
            loanDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            loanDateTimePicker.Name = "loanDateTimePicker";
            loanDateTimePicker.Size = new Size(292, 29);
            loanDateTimePicker.TabIndex = 19;
            loanDateTimePicker.Value = new DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 308);
            label2.Name = "label2";
            label2.Size = new Size(271, 25);
            label2.TabIndex = 17;
            label2.Text = "Fecha de devolucion esperada:";
            // 
            // bookComboBox
            // 
            bookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(91, 51);
            bookComboBox.Margin = new Padding(3, 4, 3, 4);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(292, 29);
            bookComboBox.TabIndex = 16;
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanDateLabel.Location = new Point(7, 200);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new Size(175, 25);
            loanDateLabel.TabIndex = 14;
            loanDateLabel.Text = "Fecha de préstamo:";
            // 
            // saveLoanButton
            // 
            saveLoanButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveLoanButton.Location = new Point(161, 472);
            saveLoanButton.Margin = new Padding(3, 4, 3, 4);
            saveLoanButton.Name = "saveLoanButton";
            saveLoanButton.Size = new Size(97, 43);
            saveLoanButton.TabIndex = 13;
            saveLoanButton.Text = "Guardar";
            saveLoanButton.UseVisualStyleBackColor = true;
            saveLoanButton.Click += saveLoanButton_Click;
            // 
            // customerTextBox
            // 
            customerTextBox.BorderStyle = BorderStyle.FixedSingle;
            customerTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerTextBox.Location = new Point(91, 123);
            customerTextBox.Margin = new Padding(3, 4, 3, 4);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.PlaceholderText = "Andrew lauttner";
            customerTextBox.Size = new Size(292, 32);
            customerTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerLabel.Location = new Point(7, 125);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(75, 25);
            customerLabel.TabIndex = 2;
            customerLabel.Text = "Cliente:";
            // 
            // bookLoanLabel
            // 
            bookLoanLabel.AutoSize = true;
            bookLoanLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookLoanLabel.Location = new Point(7, 51);
            bookLoanLabel.Name = "bookLoanLabel";
            bookLoanLabel.Size = new Size(59, 25);
            bookLoanLabel.TabIndex = 0;
            bookLoanLabel.Text = "Libro:";
            // 
            // returnsTabPage
            // 
            returnsTabPage.Controls.Add(returnsButtonsGroupBox);
            returnsTabPage.Controls.Add(returnsDataGridView);
            returnsTabPage.Controls.Add(adminReturnsLabel);
            returnsTabPage.Controls.Add(returnsGroupBox);
            returnsTabPage.Location = new Point(4, 37);
            returnsTabPage.Margin = new Padding(3, 4, 3, 4);
            returnsTabPage.Name = "returnsTabPage";
            returnsTabPage.Padding = new Padding(3, 4, 3, 4);
            returnsTabPage.Size = new Size(951, 662);
            returnsTabPage.TabIndex = 2;
            returnsTabPage.Text = "Devoluciones";
            returnsTabPage.UseVisualStyleBackColor = true;
            // 
            // returnsButtonsGroupBox
            // 
            returnsButtonsGroupBox.Controls.Add(deleteReturnButton);
            returnsButtonsGroupBox.Location = new Point(17, 511);
            returnsButtonsGroupBox.Margin = new Padding(3, 4, 3, 4);
            returnsButtonsGroupBox.Name = "returnsButtonsGroupBox";
            returnsButtonsGroupBox.Padding = new Padding(3, 4, 3, 4);
            returnsButtonsGroupBox.Size = new Size(485, 124);
            returnsButtonsGroupBox.TabIndex = 11;
            returnsButtonsGroupBox.TabStop = false;
            // 
            // deleteReturnButton
            // 
            deleteReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteReturnButton.Location = new Point(281, 52);
            deleteReturnButton.Margin = new Padding(3, 4, 3, 4);
            deleteReturnButton.Name = "deleteReturnButton";
            deleteReturnButton.Size = new Size(100, 43);
            deleteReturnButton.TabIndex = 15;
            deleteReturnButton.Text = "Eliminar";
            deleteReturnButton.UseVisualStyleBackColor = true;
            deleteReturnButton.Click += deleteReturnButton_Click;
            // 
            // returnsDataGridView
            // 
            returnsDataGridView.AllowUserToAddRows = false;
            returnsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnsDataGridView.Location = new Point(17, 64);
            returnsDataGridView.Margin = new Padding(3, 4, 3, 4);
            returnsDataGridView.Name = "returnsDataGridView";
            returnsDataGridView.RowHeadersWidth = 51;
            returnsDataGridView.RowTemplate.Height = 25;
            returnsDataGridView.Size = new Size(485, 439);
            returnsDataGridView.TabIndex = 10;
            // 
            // adminReturnsLabel
            // 
            adminReturnsLabel.AutoSize = true;
            adminReturnsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminReturnsLabel.Location = new Point(342, 23);
            adminReturnsLabel.Name = "adminReturnsLabel";
            adminReturnsLabel.Size = new Size(315, 28);
            adminReturnsLabel.TabIndex = 9;
            adminReturnsLabel.Text = "Administración de devoluciones";
            // 
            // returnsGroupBox
            // 
            returnsGroupBox.Controls.Add(labelClientName);
            returnsGroupBox.Controls.Add(labelLoanClient);
            returnsGroupBox.Controls.Add(LoanComboBox);
            returnsGroupBox.Controls.Add(label3);
            returnsGroupBox.Controls.Add(statusLoanComboBox);
            returnsGroupBox.Controls.Add(actualReturnDateTimePicker);
            returnsGroupBox.Controls.Add(actualReturnDateLabel);
            returnsGroupBox.Controls.Add(saveReturnButton);
            returnsGroupBox.Controls.Add(loanLabel);
            returnsGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnsGroupBox.Location = new Point(521, 64);
            returnsGroupBox.Margin = new Padding(3, 4, 3, 4);
            returnsGroupBox.Name = "returnsGroupBox";
            returnsGroupBox.Padding = new Padding(3, 4, 3, 4);
            returnsGroupBox.Size = new Size(411, 571);
            returnsGroupBox.TabIndex = 8;
            returnsGroupBox.TabStop = false;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Location = new Point(160, 113);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(0, 23);
            labelClientName.TabIndex = 21;
            // 
            // labelLoanClient
            // 
            labelLoanClient.AutoSize = true;
            labelLoanClient.Location = new Point(7, 113);
            labelLoanClient.Name = "labelLoanClient";
            labelLoanClient.Size = new Size(160, 23);
            labelLoanClient.TabIndex = 20;
            labelLoanClient.Text = "Nombre del cliente:";
            // 
            // LoanComboBox
            // 
            LoanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LoanComboBox.FormattingEnabled = true;
            LoanComboBox.Location = new Point(8, 76);
            LoanComboBox.Margin = new Padding(3, 4, 3, 4);
            LoanComboBox.Name = "LoanComboBox";
            LoanComboBox.Size = new Size(291, 29);
            LoanComboBox.TabIndex = 19;
            LoanComboBox.SelectedIndexChanged += LoanComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 343);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 18;
            label3.Text = "Estado de prestamo";
            // 
            // statusLoanComboBox
            // 
            statusLoanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusLoanComboBox.FormattingEnabled = true;
            statusLoanComboBox.Location = new Point(7, 392);
            statusLoanComboBox.Margin = new Padding(3, 4, 3, 4);
            statusLoanComboBox.Name = "statusLoanComboBox";
            statusLoanComboBox.Size = new Size(292, 29);
            statusLoanComboBox.TabIndex = 17;
            // 
            // actualReturnDateTimePicker
            // 
            actualReturnDateTimePicker.Location = new Point(7, 276);
            actualReturnDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            actualReturnDateTimePicker.Name = "actualReturnDateTimePicker";
            actualReturnDateTimePicker.Size = new Size(291, 29);
            actualReturnDateTimePicker.TabIndex = 16;
            // 
            // actualReturnDateLabel
            // 
            actualReturnDateLabel.AutoSize = true;
            actualReturnDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            actualReturnDateLabel.Location = new Point(7, 229);
            actualReturnDateLabel.Name = "actualReturnDateLabel";
            actualReturnDateLabel.Size = new Size(226, 25);
            actualReturnDateLabel.TabIndex = 14;
            actualReturnDateLabel.Text = "Fecha de devolución real:";
            // 
            // saveReturnButton
            // 
            saveReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveReturnButton.Location = new Point(161, 472);
            saveReturnButton.Margin = new Padding(3, 4, 3, 4);
            saveReturnButton.Name = "saveReturnButton";
            saveReturnButton.Size = new Size(97, 43);
            saveReturnButton.TabIndex = 13;
            saveReturnButton.Text = "Guardar";
            saveReturnButton.UseVisualStyleBackColor = true;
            saveReturnButton.Click += saveReturnButton_Click;
            // 
            // loanLabel
            // 
            loanLabel.AutoSize = true;
            loanLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanLabel.Location = new Point(7, 45);
            loanLabel.Name = "loanLabel";
            loanLabel.Size = new Size(151, 25);
            loanLabel.TabIndex = 0;
            loanLabel.Text = "Libro a devolver:";
            // 
            // AuthorTabPage
            // 
            AuthorTabPage.Controls.Add(label6);
            AuthorTabPage.Controls.Add(groupBox2);
            AuthorTabPage.Controls.Add(AutoresDataGridView);
            AuthorTabPage.Controls.Add(groupBox1);
            AuthorTabPage.Location = new Point(4, 37);
            AuthorTabPage.Margin = new Padding(3, 4, 3, 4);
            AuthorTabPage.Name = "AuthorTabPage";
            AuthorTabPage.Padding = new Padding(3, 4, 3, 4);
            AuthorTabPage.Size = new Size(951, 662);
            AuthorTabPage.TabIndex = 3;
            AuthorTabPage.Text = "Autores";
            AuthorTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(327, 23);
            label6.Name = "label6";
            label6.Size = new Size(262, 28);
            label6.TabIndex = 10;
            label6.Text = "Administración de autores";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UpdateAuthorButton);
            groupBox2.Controls.Add(DeleteAuthor);
            groupBox2.Location = new Point(7, 513);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(485, 124);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // UpdateAuthorButton
            // 
            UpdateAuthorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateAuthorButton.Location = new Point(37, 52);
            UpdateAuthorButton.Margin = new Padding(3, 4, 3, 4);
            UpdateAuthorButton.Name = "UpdateAuthorButton";
            UpdateAuthorButton.Size = new Size(97, 43);
            UpdateAuthorButton.TabIndex = 16;
            UpdateAuthorButton.Text = "Editar";
            UpdateAuthorButton.UseVisualStyleBackColor = true;
            UpdateAuthorButton.Click += UpdateAuthorButton_Click;
            // 
            // DeleteAuthor
            // 
            DeleteAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAuthor.Location = new Point(281, 52);
            DeleteAuthor.Margin = new Padding(3, 4, 3, 4);
            DeleteAuthor.Name = "DeleteAuthor";
            DeleteAuthor.Size = new Size(97, 43);
            DeleteAuthor.TabIndex = 15;
            DeleteAuthor.Text = "Eliminar";
            DeleteAuthor.UseVisualStyleBackColor = true;
            DeleteAuthor.Click += DeleteAuthor_Click;
            // 
            // AutoresDataGridView
            // 
            AutoresDataGridView.AllowUserToAddRows = false;
            AutoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AutoresDataGridView.Location = new Point(7, 67);
            AutoresDataGridView.Margin = new Padding(3, 4, 3, 4);
            AutoresDataGridView.Name = "AutoresDataGridView";
            AutoresDataGridView.RowHeadersWidth = 51;
            AutoresDataGridView.RowTemplate.Height = 25;
            AutoresDataGridView.Size = new Size(485, 439);
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
            groupBox1.Location = new Point(531, 67);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(411, 439);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 124);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 17;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 49);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 16;
            label4.Text = "Nombre";
            // 
            // authorLastNameTextBox
            // 
            authorLastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorLastNameTextBox.Location = new Point(88, 124);
            authorLastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            authorLastNameTextBox.Name = "authorLastNameTextBox";
            authorLastNameTextBox.PlaceholderText = "Glukhovsky";
            authorLastNameTextBox.Size = new Size(292, 29);
            authorLastNameTextBox.TabIndex = 15;
            // 
            // SaveAuthorButton
            // 
            SaveAuthorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveAuthorButton.Location = new Point(151, 371);
            SaveAuthorButton.Margin = new Padding(3, 4, 3, 4);
            SaveAuthorButton.Name = "SaveAuthorButton";
            SaveAuthorButton.Size = new Size(97, 43);
            SaveAuthorButton.TabIndex = 13;
            SaveAuthorButton.Text = "Guardar";
            SaveAuthorButton.UseVisualStyleBackColor = true;
            SaveAuthorButton.Click += SaveAuthorButton_Click;
            // 
            // authorFirstNameTextBox
            // 
            authorFirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorFirstNameTextBox.Location = new Point(88, 47);
            authorFirstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            authorFirstNameTextBox.PlaceholderText = "Dmitry";
            authorFirstNameTextBox.Size = new Size(292, 29);
            authorFirstNameTextBox.TabIndex = 14;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 735);
            Controls.Add(libraryTabControl);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label labelClientName;
        private Label labelLoanClient;
        private TextBox searchBookTextBox;
        private Label label7;
    }
}