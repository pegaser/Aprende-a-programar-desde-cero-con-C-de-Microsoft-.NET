   M S B A M L   `   `   `  ����I  EOthersElements, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:OthersElementsOthersElements  5   	       OthersElements.Margins   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:OthersElements     5   	   -   5          � Title$  Change Margins��5   	   $	��200��5	   	   $	��300��5
   	    � SizeToContent$ WidthAndHeight=�5   	    � 
ResizeMode$ NoResize=�5   	    � ShowInTaskbar$ False��5   	    � WindowStartupLocation$ CenterOwner=�5   	    +� FocusedElement 5   	   ��  �� ElementName$ leftMarginTextBox��.��5      � $��10q�6    � 	Resources 5   
    �� 
TargetType	 �� Property
 �� Value��%v  '��       '�� v     '�� �     �� 5      " ��6   .�5      �� 	 � ��$
 0,3,5,5q�6+   �� 5      	 � ��$
 0,0,0,5q�6,   5      �� 5      " ��6   .�5      �� 	 � ��$
 0,0,0,5q�6+   5      �� 5      " ��6   .�5      �� 	 � ��$
 70��6*   �� 5      	 � ��$
 25��6+   �� 5      	 � ��$
 5,0,0,0q�6+   5      5       � ColumnDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#       � RowDefinitions 5&   
   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      .+�50   
   �� $��0��6   $��0��6    .��6-   Left Margin:6;   �� 51   
   -   5        $��leftMarginTextBox��51      $��1��6+   $��0��6;   �� 53   
   $��0��6   $��1��6    .��6-   Top Margin:6:   �� 54   
   -   5        $��topMarginTextBox��54      $��1��6*   $��1��6:   �� 56   
   $��0��6   $��2��6    .��6-   Right Margin:6<   �� 57   
   -   5        $��rightMarginTextBox��57      $��1��6,   $��2��6<   �� 59   
   $��0��6   $��3��6    .��6-   Bottom Margin:6=   �� 5:   
   -   5        $��bottomMarginTextBox��5:      $��1��6-   $��3��6=   �� 5=   
   $��0��6   $��2��6%   $��4��69    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   .+�5>      �� -   5        $��okButton��5>       �� 	IsDefault$
 True��6<   .��6M   OK6Q   �� 5?      -   5        $��cancelButton��5?       �� IsCancel$
 True��6)   .��6T   Cancel6\   5@      5A      5B      