   M S B A M L   `   `   `  ����F  BDataDisplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DataDisplayDataDisplay  5   	       DataDisplay.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DataDisplay     5   	   -   5          � Title$  
MainWindow��5      $	��450��6-   $	��800��6:   .��5      �� $��10q�6   .+�5	   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CustomerGrid��5	         AlternatingRowBackground
 ��ح� �� AlternationCount$ 1��6f      AutoGenerateColumns$
 True��6{   ��6)   �� 6{     5
   
   -   5        $��CustomerGrid2��5
      $ False��6@   ��6(   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre Completo��6%      
IsReadOnly$
 True��6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Name+6X     5      $ 
Dirección��6%    68   �� *	Address+  5      $
 Edad��6%    63   �� *Age+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ ¿Es Miembro?��6)    6?   �� *
IsMember+5      R� 5   
   .@�5      Q� $��	Employee1��6   .@�5      Q� $��Jesper��6   Q� 5      $��Aaberg��6   Q� 5      $��12345��6   .@�5      Q� $��Other��6#   5      5      Q� 5      $��	Employee2��6   .@�5      Q� $��Dominik��6   Q� 5      $��Paiha��6   Q� 5      $��98765��6   5      5      R� 5    
   -   5        $��trvMyTreeView��5       ��5!      �� 5"      	 �� DataType   DataDisplay.Customer"	  6+   
 �� ItemsSource
 6N   �� *
Partners+.R�5#      �� ��6    �� *Name+5$      5&      �� 5'   
   -   5        $��lsvCustomers��5'      $��10q�6    �� View 5(      �� 5)      .P�5*      �� $��Nombre��6%    �� Width$	 120��65    �� DisplayMemberBinding 6A   �� *Name+�� 5+      $
��Edad��6%   $ 50��63    6>   �� *Age+�� 5,      $��
Dirección��6%   $	 150��68    6D   �� *	Address+5-      5/      50      51      