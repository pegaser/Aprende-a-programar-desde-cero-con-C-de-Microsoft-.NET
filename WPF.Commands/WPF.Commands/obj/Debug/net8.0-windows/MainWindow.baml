   M S B A M L   `   `   `  ����G  CWPF.Commands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF.CommandsWPF.Commands  5   	       WPF.Commands.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF.Commands     5   	     � WindowStartupLocation$  CenterScreen=�62    � Title$ 
MainWindow��5      $	��450��6-   $	��800��6:    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5	   
   -   5           Command$ ApplicationCommands.New��5	      6\     5
   
   -   5        $ ApplicationCommands.Save��5
      6�   .��5      �� .+�5   
   o� .@�5      m� $
��File��6   .@�5      m�  m� Command$	 New��6   6+   m� 5      $
 Save��6   6,   5      5      c� 5   
   .@�5      �� $	��Cut��6   .��6#   Cut6(   �� 5      $
��Copy��6   .��6$   Copy6*   �� 5      $��Paste��6   .��6%   Paste6,   5      �� 5   
   $	��Cut��6   ��6   ��  �� ElementName$ txtMyTextBox2��.��6S   Cut6X   �� 5   
   $
��Copy��6   ��6    �� $ txtMyTextBox2��.��6T   Copy6Z   �� 5   
   $��Paste��6   ��6!   �� $ txtMyTextBox2��.��6U   Paste6\   �� 5   
   �� 5   
   $��5q�6    +� IsFocusScope$
 True��6    .+�5   
   �� $	��Cut��6   .��6    Cut6%   �� 5   
   $
��Copy��6   .��6!   Copy6'   �� 5    
   $��Paste��6   .��6"   Paste6)   5!      �� 5"   
   $��ApplicationCommands.New��6   ��63   ��  �� RelativeSource �� *Self+ �� Path$ Command.Text�6�   �� 5#   
   -   5        $��txtMyTextBox��5#      6O   �� 5$   
   -   5        $��txtMyTextBox2��5$      6Q   5%      5&      