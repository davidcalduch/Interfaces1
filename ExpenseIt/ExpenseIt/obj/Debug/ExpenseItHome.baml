   M S B A M L   `   `   `  ����  	ExpenseIt    ExpenseIt.ExpenseItHome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ExpenseIt - Home��5       � 	Resources 5
         nameItemTemplate �� XPath  typeItemTemplate  amountItemTemplate  ExpenseDataSource � XPath��%o  &	        &	 B     &	 �     &	 �     �� 5   
   .R�5      �� ��6   �� $ @Name��5      �� 5   
   .R�5      �� ��6   �� $ @ExpenseType��5      �� 5   
   .R�5      �� ��6   �� $ @ExpenseAmount��5      � 5   
   $ Expenses��64   .��5      ��<Expenses xmlns="">
                    <Person Name="Mike" Department="Legal">
                        <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                        <Expense ExpenseType="Transportation" ExpenseAmount="50" />
                    </Person>
                    <Person Name="Lisa" Department="Marketing">
                        <Expense ExpenseType="Document printing" ExpenseAmount="50" />
                        <Expense ExpenseType="Gift" ExpenseAmount="125" />
                    </Person>
                    <Person Name="John" Department="Engineering">
                        <Expense ExpenseType="Magazine subscription" ExpenseAmount="50" />
                        <Expense ExpenseType="New machine" ExpenseAmount="600" />
                        <Expense ExpenseType="Software" ExpenseAmount="500" />
                    </Person>
                    <Person Name="Mary" Department="Finance">
                        <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                    </Person>
                </Expenses>        5+      5,      .��5.      � $��
10,0,10,10q�6    � ColumnDefinitions 5/   
   �� 50      $	��230 �6   �� 51       � RowDefinitions 54   
   �� 55      �� 56      $
��Auto �6   �� 57      �� 58      $
��Auto �6   .+�5<   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   View Expense Report5>      �� 5?   
   $��1��6   $��1��6!     listHeaderStyle#��[ 6.   ._�5@      ��   listHeaderTextStyle#��[ 6   .��6A   Names6H   5A      �� 5B   
   -   5        $��peopleListBox��5B      $��1��6'   $��2��67   #��[  5D      ��5C      ��  �� Source# [ $ Person��5E      �� 5H   
   -   5        $��1��5H      $��3��6!     buttonStyle#��[ 6C   .��6h   View6n   �� 5K   
   $��0��6   $��2��6%   $��0��69    �� Orientation$ 
Horizontal=�6F   .+�5L      ��   
labelStyle#��[ 6   .��68   Name:6?   �� 5M      #��[ 6   ��68   �� $ @Name��6Z   5N      �� 5Q   
   $��0��6   $��2��6%   $��1��69   $ 
Horizontal=�6F   .+�5R      �� #��[ 6   .��68   Department:6E   �� 5S      #��[ 6   ��68   �� $ @Department��6`   5T      � 5V   
   $��0��6   $��2��6   $��2��63   $	��Top=�6@   $
��Left=�5W      .+�5Y      &   System.Windows.Controls.DataGrid   	 columnHeaderStyle   ColumnHeaderStyle# [	 6=   	   AutoGenerateColumns	 .  
   RowHeaderWidth$
 0Q�6�   ��6   �� $ Expense��   Columns 5Z      4  .System.Windows.Controls.DataGridTemplateColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6-      CellTemplate# [ 6B     5\      $ Amount��6-   # [ 6=   5^      5_      5`      5a      