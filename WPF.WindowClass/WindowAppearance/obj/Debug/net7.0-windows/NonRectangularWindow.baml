   M S B A M L   `   `   `  ����K  GWindowAppearance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WindowAppearanceWindowAppearance  5   	   +    %WindowAppearance.NonRectangularWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WindowAppearance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ NonRectangularWindow��5   	    � SizeToContent$ WidthAndHeight=�6&    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��6   
������ .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� ���	#FF000000 �� RadiusX$ 10��6'    �� RadiusY$ 10��64   F� 5   
   
������� �� Stretch$
 Fill=�6   ���	#FF000000$
��Left=�6>   $��15,-5.597,0,-0.003q�5      $��30��6+   $��1��66   "����r<R2�4	�2��.�/�lnN'6		5      �� 5   
   
�������$ 10��6!   $ 10��6.   $��1q�6;   �� 5   
   $
��Left=�6   $��Center=�6/   $��25(�6J   $��
Greetings!��6X   $
��Wrap=�6j   $��5,5,50,5q�6~   �� 5   
   $��Right=�6   $	��Top=�6-   
������ 
���  ��$	��❌��6�   $��15(�6�   ��6^   Z� 6�   	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 10Q�6      ShadowDepth$ 3Q�6/      Color$ 	LightBlue��6?   5      5      