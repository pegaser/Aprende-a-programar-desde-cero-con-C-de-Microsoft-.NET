   M S B A M L   `   `   `  ����G  CWPF.Bindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF.BindingsWPF.Bindings  5   	       WPF.Bindings.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF.Bindings     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� $��10q�6   .+�5
   
   �� -   5         ��Name$ 
txtContent��5
      $��Texto Simple��6&   �� 5   
   -   5        $��sliderFontSize��5      $��3q�6'    � Minimum$ 1Q�62    � Maximum$ 40Q�6>    � Value$ 10Q�6K    �� TickFrequency$ 1Q�6V    �� TickPlacement$ TopLeft=�6h   �� 5   
   -   5        $��lblSampleText��5       $��10q�6   ��65   ��  �� ElementName$ sliderFontSize�� �� Path$ Value�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Delay$
 3000����6�   �� $ 
txtContent��$
 Text��� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��btnSmall��5      $��5q�6<   .��6G   
Pequeño6P   �� 5      -   5        $��	btnNormal��5      $��5q�6>   .��6I   Normal6Q   �� 5      -   5        $��btnLarge��5      $��5q�6<   .��6G   Grande6O   5      5      5      