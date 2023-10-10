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
            saveBookButton = new Button();
            authorLastNameTextBox = new TextBox();
            statusBookTextBox = new TextBox();
            statusBookLabel = new Label();
            genreTextBox = new TextBox();
            genreLabel = new Label();
            isbnBookTextBox = new TextBox();
            isbnBookLabel = new Label();
            publisherTextBox = new TextBox();
            publisherBookLabel = new Label();
            authorFirstNameTextBox = new TextBox();
            authorLabel = new Label();
            titleBookTextBox = new TextBox();
            titleBookLabel = new Label();
            loansTabPage = new TabPage();
            loansButtonsGroupBox = new GroupBox();
            deleteLoanButton = new Button();
            editLoanButton = new Button();
            loansDataGridView = new DataGridView();
            adminLoansLabel = new Label();
            loansGroupBox = new GroupBox();
            loanDateTextBox = new TextBox();
            loanDateLabel = new Label();
            saveLoanButton = new Button();
            customerTextBox = new TextBox();
            customerLabel = new Label();
            bookLoanTextBox = new TextBox();
            bookLoanLabel = new Label();
            returnsTabPage = new TabPage();
            returnsButtonsGroupBox = new GroupBox();
            deleteReturnButton = new Button();
            editReturnButton = new Button();
            returnsDataGridView = new DataGridView();
            adminReturnsLabel = new Label();
            returnsGroupBox = new GroupBox();
            actualReturnDateTextBox = new TextBox();
            actualReturnDateLabel = new Label();
            saveReturnButton = new Button();
            estimatedReturnTextBox = new TextBox();
            estimatedReturnDateLabel = new Label();
            loanTextBox = new TextBox();
            loanLabel = new Label();
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
            SuspendLayout();
            // 
            // libraryTabControl
            // 
            libraryTabControl.Controls.Add(booksTabPage);
            libraryTabControl.Controls.Add(loansTabPage);
            libraryTabControl.Controls.Add(returnsTabPage);
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
            // 
            // editBookButton
            // 
            editBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBookButton.Location = new Point(81, 39);
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(85, 32);
            editBookButton.TabIndex = 14;
            editBookButton.Text = "Editar";
            editBookButton.UseVisualStyleBackColor = true;
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
            booksGroupBox.Controls.Add(saveBookButton);
            booksGroupBox.Controls.Add(authorLastNameTextBox);
            booksGroupBox.Controls.Add(statusBookTextBox);
            booksGroupBox.Controls.Add(statusBookLabel);
            booksGroupBox.Controls.Add(genreTextBox);
            booksGroupBox.Controls.Add(genreLabel);
            booksGroupBox.Controls.Add(isbnBookTextBox);
            booksGroupBox.Controls.Add(isbnBookLabel);
            booksGroupBox.Controls.Add(publisherTextBox);
            booksGroupBox.Controls.Add(publisherBookLabel);
            booksGroupBox.Controls.Add(authorFirstNameTextBox);
            booksGroupBox.Controls.Add(authorLabel);
            booksGroupBox.Controls.Add(titleBookTextBox);
            booksGroupBox.Controls.Add(titleBookLabel);
            booksGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            booksGroupBox.Location = new Point(456, 48);
            booksGroupBox.Name = "booksGroupBox";
            booksGroupBox.Size = new Size(360, 428);
            booksGroupBox.TabIndex = 0;
            booksGroupBox.TabStop = false;
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
            // 
            // authorLastNameTextBox
            // 
            authorLastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorLastNameTextBox.Location = new Point(86, 101);
            authorLastNameTextBox.Name = "authorLastNameTextBox";
            authorLastNameTextBox.Size = new Size(256, 25);
            authorLastNameTextBox.TabIndex = 12;
            authorLastNameTextBox.Text = "Apellido";
            // 
            // statusBookTextBox
            // 
            statusBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            statusBookTextBox.Location = new Point(86, 264);
            statusBookTextBox.Name = "statusBookTextBox";
            statusBookTextBox.Size = new Size(256, 25);
            statusBookTextBox.TabIndex = 11;
            // 
            // statusBookLabel
            // 
            statusBookLabel.AutoSize = true;
            statusBookLabel.Location = new Point(15, 268);
            statusBookLabel.Name = "statusBookLabel";
            statusBookLabel.Size = new Size(51, 17);
            statusBookLabel.TabIndex = 10;
            statusBookLabel.Text = "Estado:";
            // 
            // genreTextBox
            // 
            genreTextBox.BorderStyle = BorderStyle.FixedSingle;
            genreTextBox.Location = new Point(86, 222);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(256, 25);
            genreTextBox.TabIndex = 9;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(15, 226);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(54, 17);
            genreLabel.TabIndex = 8;
            genreLabel.Text = "Género:";
            // 
            // isbnBookTextBox
            // 
            isbnBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            isbnBookTextBox.Location = new Point(86, 182);
            isbnBookTextBox.Name = "isbnBookTextBox";
            isbnBookTextBox.Size = new Size(256, 25);
            isbnBookTextBox.TabIndex = 7;
            // 
            // isbnBookLabel
            // 
            isbnBookLabel.AutoSize = true;
            isbnBookLabel.Location = new Point(15, 186);
            isbnBookLabel.Name = "isbnBookLabel";
            isbnBookLabel.Size = new Size(38, 17);
            isbnBookLabel.TabIndex = 6;
            isbnBookLabel.Text = "ISBN:";
            // 
            // publisherTextBox
            // 
            publisherTextBox.BorderStyle = BorderStyle.FixedSingle;
            publisherTextBox.Location = new Point(86, 142);
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new Size(256, 25);
            publisherTextBox.TabIndex = 5;
            // 
            // publisherBookLabel
            // 
            publisherBookLabel.AutoSize = true;
            publisherBookLabel.Location = new Point(15, 147);
            publisherBookLabel.Name = "publisherBookLabel";
            publisherBookLabel.Size = new Size(59, 17);
            publisherBookLabel.TabIndex = 4;
            publisherBookLabel.Text = "Editorial:";
            // 
            // authorFirstNameTextBox
            // 
            authorFirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            authorFirstNameTextBox.Location = new Point(86, 62);
            authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            authorFirstNameTextBox.Size = new Size(256, 25);
            authorFirstNameTextBox.TabIndex = 3;
            authorFirstNameTextBox.Text = "Nombre";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(15, 68);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(43, 17);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Autor:";
            // 
            // titleBookTextBox
            // 
            titleBookTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleBookTextBox.Location = new Point(86, 23);
            titleBookTextBox.Name = "titleBookTextBox";
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
            loansGroupBox.Controls.Add(loanDateTextBox);
            loansGroupBox.Controls.Add(loanDateLabel);
            loansGroupBox.Controls.Add(saveLoanButton);
            loansGroupBox.Controls.Add(customerTextBox);
            loansGroupBox.Controls.Add(customerLabel);
            loansGroupBox.Controls.Add(bookLoanTextBox);
            loansGroupBox.Controls.Add(bookLoanLabel);
            loansGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loansGroupBox.Location = new Point(456, 48);
            loansGroupBox.Name = "loansGroupBox";
            loansGroupBox.Size = new Size(360, 428);
            loansGroupBox.TabIndex = 4;
            loansGroupBox.TabStop = false;
            // 
            // loanDateTextBox
            // 
            loanDateTextBox.BorderStyle = BorderStyle.FixedSingle;
            loanDateTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanDateTextBox.Location = new Point(51, 273);
            loanDateTextBox.Name = "loanDateTextBox";
            loanDateTextBox.Size = new Size(256, 27);
            loanDateTextBox.TabIndex = 15;
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanDateLabel.Location = new Point(106, 241);
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
            customerTextBox.Location = new Point(51, 169);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.Size = new Size(256, 27);
            customerTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerLabel.Location = new Point(152, 136);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(58, 20);
            customerLabel.TabIndex = 2;
            customerLabel.Text = "Cliente:";
            // 
            // bookLoanTextBox
            // 
            bookLoanTextBox.BorderStyle = BorderStyle.FixedSingle;
            bookLoanTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookLoanTextBox.Location = new Point(51, 69);
            bookLoanTextBox.Name = "bookLoanTextBox";
            bookLoanTextBox.Size = new Size(256, 27);
            bookLoanTextBox.TabIndex = 1;
            // 
            // bookLoanLabel
            // 
            bookLoanLabel.AutoSize = true;
            bookLoanLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookLoanLabel.Location = new Point(151, 37);
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
            returnsGroupBox.Controls.Add(actualReturnDateTextBox);
            returnsGroupBox.Controls.Add(actualReturnDateLabel);
            returnsGroupBox.Controls.Add(saveReturnButton);
            returnsGroupBox.Controls.Add(estimatedReturnTextBox);
            returnsGroupBox.Controls.Add(estimatedReturnDateLabel);
            returnsGroupBox.Controls.Add(loanTextBox);
            returnsGroupBox.Controls.Add(loanLabel);
            returnsGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnsGroupBox.Location = new Point(456, 48);
            returnsGroupBox.Name = "returnsGroupBox";
            returnsGroupBox.Size = new Size(360, 428);
            returnsGroupBox.TabIndex = 8;
            returnsGroupBox.TabStop = false;
            // 
            // actualReturnDateTextBox
            // 
            actualReturnDateTextBox.BorderStyle = BorderStyle.FixedSingle;
            actualReturnDateTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            actualReturnDateTextBox.Location = new Point(51, 273);
            actualReturnDateTextBox.Name = "actualReturnDateTextBox";
            actualReturnDateTextBox.Size = new Size(256, 27);
            actualReturnDateTextBox.TabIndex = 15;
            // 
            // actualReturnDateLabel
            // 
            actualReturnDateLabel.AutoSize = true;
            actualReturnDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            actualReturnDateLabel.Location = new Point(91, 241);
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
            // estimatedReturnTextBox
            // 
            estimatedReturnTextBox.BorderStyle = BorderStyle.FixedSingle;
            estimatedReturnTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            estimatedReturnTextBox.Location = new Point(51, 169);
            estimatedReturnTextBox.Name = "estimatedReturnTextBox";
            estimatedReturnTextBox.Size = new Size(256, 27);
            estimatedReturnTextBox.TabIndex = 3;
            // 
            // estimatedReturnDateLabel
            // 
            estimatedReturnDateLabel.AutoSize = true;
            estimatedReturnDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            estimatedReturnDateLabel.Location = new Point(77, 137);
            estimatedReturnDateLabel.Name = "estimatedReturnDateLabel";
            estimatedReturnDateLabel.Size = new Size(213, 20);
            estimatedReturnDateLabel.TabIndex = 2;
            estimatedReturnDateLabel.Text = "Fecha de devolución estimada:";
            // 
            // loanTextBox
            // 
            loanTextBox.BorderStyle = BorderStyle.FixedSingle;
            loanTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanTextBox.Location = new Point(51, 69);
            loanTextBox.Name = "loanTextBox";
            loanTextBox.Size = new Size(256, 27);
            loanTextBox.TabIndex = 1;
            // 
            // loanLabel
            // 
            loanLabel.AutoSize = true;
            loanLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanLabel.Location = new Point(151, 37);
            loanLabel.Name = "loanLabel";
            loanLabel.Size = new Size(74, 20);
            loanLabel.TabIndex = 0;
            loanLabel.Text = "Préstamo:";
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
        private TextBox authorLastNameTextBox;
        private TextBox statusBookTextBox;
        private Label statusBookLabel;
        private TextBox genreTextBox;
        private Label genreLabel;
        private TextBox isbnBookTextBox;
        private Label isbnBookLabel;
        private TextBox publisherTextBox;
        private Label publisherBookLabel;
        private TextBox authorFirstNameTextBox;
        private Label authorLabel;
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
        private TextBox bookLoanTextBox;
        private Label bookLoanLabel;
        private TextBox loanDateTextBox;
        private Label loanDateLabel;
        private GroupBox returnsButtonsGroupBox;
        private Button deleteReturnButton;
        private Button editReturnButton;
        private DataGridView returnsDataGridView;
        private Label adminReturnsLabel;
        private GroupBox returnsGroupBox;
        private TextBox actualReturnDateTextBox;
        private Label actualReturnDateLabel;
        private Button saveReturnButton;
        private TextBox estimatedReturnTextBox;
        private Label estimatedReturnDateLabel;
        private TextBox loanTextBox;
        private Label loanLabel;
    }
}