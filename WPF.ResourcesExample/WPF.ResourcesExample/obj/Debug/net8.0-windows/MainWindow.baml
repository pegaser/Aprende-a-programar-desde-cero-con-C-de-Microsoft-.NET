   M S B A M L   `   `   `  ����O  KWPF.ResourcesExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF.ResourcesExampleWPF.ResourcesExample  5   	   G CMyWpfLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:MyWpfLibrary;assembly=MyWpfLibraryMyWpfLibrary 5   	   %    WPF.ResourcesExample.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WPF.ResourcesExample     5   	   @res0clr-namespace:MyWpfLibrary;assembly=MyWpfLibrary     5   	     � Title$  
MainWindow��5      $	��800��6-   $	��800��6:    � 	Resources 5	         	TileBrush j� TileMode j� ViewportUnits j� Viewport �� ImageSource �� Opacity��%u   &	        �� 5
   
   $
 Tile=�6'   $ Absolute=�67   $ 	0 0 32 32�6P   $ 	emoji.png��6e   $	 0.3Q�6}   5      .��5      �� $��10q�6   .+�5   
   �� Colección de Recursos6+   �� 5   
   #��[  6   $��14(�69   $��30��6G   $	��300��6S   .��6_   A Tiled Button6o   �� 5   
   #��[  6   .��69   A Tiled Button 26K   �� 5   
   $��20q�6   �� 5   
   Jerarquía de recursos6+   �� 5   
    5        MyBrush2��%=   &	       �� 5      $
 None=�6.   $ 	emoji.png��6>   5      .+�5      �� #��[ 6   $��30��6<   $��30��6H   6U   �� 5      #��[ 6   $��30��6<   $��30��6H   6U   5      �� 5   
   $��30��6   $��30��6   #���   6(    5      ��%=   &	        �� 5      $
 None=�6/   $ 	emoji.png��6?   5      5      �� 5   
   $��20q�6   �� 5   
   !Recursos dinámico y estáticos63   �� 5    
   -   5         ��Name$ btnChangeResource��5       .��6L   Cambia Mosaico6\   �� 5!   
   #���   6   .��6:   A Tiled Button 26L   �� 5#   
   $��20q�6   �� 5$   
   &$Recursos de aplicación y de sistema69   �� 5%   
   -   5        $ btnOpenWindow2��5%      .��6F   Abre segunda ventana6\   �� 5'   
   $��20q�6   �� 5(   
   Diccionario de recursos6-   �� 5)   
     TileBrushDictionary#��[ 6   .��6D   Desde Diccionario6W   �� 5*   
   -   5        $��btnPink��5*      .��6!   Desde Diccionario 266   �� 5+   
   ��6   C� *��  �� TypeInTargetAssembly"  MyWpfLibrary.CustomResources"  	 �� 
ResourceId$	 brushRed��+.��6�   !A Resource From ResourceLibrary5-      �� 5.   
   
   RedBrushKey#��� 
 6   .��6[   !A Resource From ResourceLibrary50      51      52      