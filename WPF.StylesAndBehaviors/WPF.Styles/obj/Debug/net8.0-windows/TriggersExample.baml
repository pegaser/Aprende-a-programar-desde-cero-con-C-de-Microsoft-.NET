   M S B A M L   `   `   `  ����E  AWPF.Styles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF.Styles
WPF.Styles  5   	        WPF.Styles.TriggersExample   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF.Styles     5   	     � Title$  TriggersExample��5   	   $	��450��6!   $	��800��6.    � 	Resources 5         BigFontButton �� Property �� Value �� Triggers P� Property P� Value  BigFontButton2 ]� 
Conditions �� Property	 �� Value  BigFontButtonEvent
 :� RoutedEvent g� Duration �� TargetProperty	 W� To��%�  &	        &	 �    &	 �    �� 5	   
   �5
      �� 5       � ��$ Arial)�69   �� 5       � ��$ 30(�67    5      P� 5       �@J�	IsFocused$
 True��67   . �5      ��  � ��
 � � �6;   5      P� 5       �@J�IsMouseOver$
 True��69   . �5      ��  � ��
 �����6;   �� 5       � ��$
 Bold"�6;   5      P� 5       � ��$
 True��66   . �5      ��  � ��
 �  ��6;   5      5      �� 5   
   �5      �� 5       � ��$ Arial)�69   �� 5       � ��$ 30(�67    5       ]� 5!       5"      �� 5#       �@J�	IsFocused$
	 True��6A   �� 5$       �@J�IsMouseOver$
	 True��6C   /�5&      �� 5'       � ��
 � � �6?   5)      5+      �� 5,   
   �5-      �� 5.       � ��$ Arial)�69   �� 5/       � ��$ 10(�67    51      :� 52      $
 Mouse.MouseEnter��6   [�53      �� 54      .��55      �� .��56   "   W� $ 0:0:0.2D�62   $ FontSize�6E    226j   57      58      5:      :� 5;      $
 Mouse.MouseLeave��6   [�5<      �� 5=      .��5>      �� .��5?   "   W� $ 0:0:1D�62   $ FontSize�6C   5@      5A      5C      5F      5G      .��5H      �� .+�5I   
   �� $��10q�6   .+�5J      �� #��[  6   .��6<   Ejemplo de un Trigger Simple6Z   5K      �� 5L   
   $��10q�6   .+�5M      �� .��6   Cualquier botón6&   5N      �� 5O   
   $��10q�6   .+�5P      �� #��[ 6   .��6=   Ejemplo de un MultiTrigger6Y   5Q      �� 5R   
   $��10q�6   .+�5S      �� #��[ 6   .��6A   Ejemplo de un EventTrigger6]   5T      5U      5V      