   M S B A M L   `   `   `  ����H  DStockOptimize, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StockOptimize.ViewStockOptimize.View  5   	   '    !StockOptimize.View.crearBasesView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:StockOptimize.View     5   	     � Title$  Bases de Datos��5   	   $
��1080��6    $
��1920��6.    � WindowStyle$ SingleBorderWindow=�5	   	    � 
ResizeMode$ 	CanResize=�6*   .��5      �� ��5   
   �� 5       �� 
StartPoint$	 0,1&�6"    �� EndPoint$	 1,0&�63   .��5      �  � Color$ #060531��6    � Offset$ 0Q�6/   � 5      $ #1B1448��6   $ 1Q�6/   5      ._�5   
   �  � RowDefinitions 5      �� 5      $	��200 �6    �� 5      .+�5      �� $��0��6   $��200,80,200,0q�6&   $	��Top=�6<   $��Center=�6T   .+�5      �� $��2q�6    �� CornerRadius$ 10��5      ��5      �� 5      $	 0,0&�6.   $	 1,1&�6?   .��5      � $ #462AD8��6+   $ 0Q�6;   � 5       $ #DA34AE��6+   $
 0.75Q�6;   � 5!      $ #8A16C1��6+   $ 1Q�6;   5"      ._�5%      �� .+�5&      �� $��Nombre Tabla��6$   
�������$��
Montserrat)�5(   $   $��20(�5)   $   $��
20,20,0,10q�5*   $   $��Medium"�5+   $   �� 5-      
�������$��2q�5.   !   $ 5��5/   !   $��
30,0,20,10q�50   !   ._�52      �� -   5        $��txtTabla��52   &   $
��1000��53   &   $
��Left=�54   &   $��35��55   &   $��15(�56   &   $��
Montserrat)�57   &   
�������	 �� 
CaretBrush
	 �����
������ $��0q�5;   &   $��Bottom=�5<   &   $��Center=�5=   &   $��5,0,0,0q�5>   &   5?      5@      5A      5B      �� 5D      $��1��6   $��2q�5E      $ 10��5F      $��10q�5G      ��5I      �� 5J      $	 0,0&�6*   $	 1,1&�6;   .��5K      � $ #462AD8��6'   $ 0Q�67   � 5L      $ #DA34AE��6'   $
 0.75Q�67   � 5M      $ #8A16C1��6'   $ 1Q�67   5N      ._�5Q      �  5S      �� 5T      $��80 �6(   �� 5U      .+�5X      � $��0��6   
 � ColumnDefinitions
 5Y      �� 5Z      �� 5[      �� 5\      �� 5]      �� 5^      �� 5_      .+�5d      �� -   5        $��
btnAñadir��5i   !   $��0��5d   !   $��	+ Añadir��5e   !   
�������$��
Montserrat)�5g   !    � Cursor$
 Hand��5h   !   ��5k      �� 5l   "    �� 
TargetType" ��6(   .�5m   &   ��  �� Property � �� �� Value �#462AD86C    �� Triggers 5n   &   P� 5o   *    P� Property �@J�IsMouseOver P� Value . . �5p   .   ��  � �� �#28AEED6K   5q   +   5s   #   ��5v      �� 5w   "    �� 
TargetType" ��62   .R�5x   &   �� $	��200��6-   $��50��69   $ 20��5y   (   #��z��5z   (   ._�5{   *   �� $��Center=�6;   $��Center=�5|   6   5}   '   5~   #   5�      �� 5�      -   5        $��btnEliminar��5�   !   $��1��5�   !   $��
- Eliminar��5�   !   
�������$��
Montserrat)�5�   !   $
 Hand��5�   !   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�   $   #��z��5�   $   ._�5�   *   �� $��Center=�6;   $��Center=�5�   6   5�   '   5�   #   5�      �� 5�      -   5        $��btnMoverPrincipio��5�   !   $��2��5�   !   $��⏫ Mover al principio��5�   !   
�������$��
Montserrat)�5�   !   $
 Hand��5�   !   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�   $   #��z��5�   $   ._�5�   *   �� $��Center=�6;   $��Center=�5�   6   5�   '   5�   #   5�      �� 5�      -   5        $��btnMoverArriba��5�   !   $��3��5�   !   $��🔼 Mover arriba��5�   !   
�������$��
Montserrat)�5�   !   $
 Hand��5�   !   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�   $   #��z��5�   $   ._�5�   *   �� $��Center=�6;   $��Center=�5�   6   5�   '   5�   #   5�      �� 5�      -   5        $��btnMoverAbajo��5�   !   $��4��5�   !   $��🔽 Mover Abajo��5�   !   
�������$��
Montserrat)�5�   !   $
 Hand��5�   !   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�   $   #��z��5�   $   ._�5�   *   �� $��Center=�6;   $��Center=�5�   6   5�   '   5�   #   5�      �� 5�      -   5        $��btnMoverFinal��5  !   $��5��5�   !   $��⏬ Mover al final��5   !   
�������$��
Montserrat)�5  !   $
 Hand��5  !   ��5     �� 5  "   " ��6(   .�5  &   ��  � �� �#462AD86C    5	  &   P� 5
  *    �@J�IsMouseOver . . �5  .   ��  � �� �#28AEED6K   5  +   5  #   ��5     �� 5  "   " ��62   .R�5  &   �� $	��200��6-   $��50��69   $ 20��5  $   #��z��5  $   ._�5  *   �� $��Center=�6;   $��Center=�5  6   5  '   5  #   5     5      �� 5$     -   5        $��lbTabla��5$     $��1��5%     $��Stretch=�5&     
������ ��5(     �� 5)     .R�5*  "   �  5+  &   �� 5,  *   $
��Auto �68   �� 5-  *   
 51  &   �� 52  *   $��* �6;   �� 53  *   $��* �6;   �� 54  *   $��* �6;   �� 55  *   $��* �6;   �� 56  *   $��* �6;   �� 57  *   $��30 �6;   .+�5:  &   �� $��Nombre��6,   $��0��5;  ,   $��0��69   �� 5=  &   $
��Tipo��6,   $��0��5>  ,   $��1��69   �� 5@  &   $��NN��6,   $��0��5A  ,   $��2��69   �� 5C  &   $��PK��6,   $��0��5D  ,   $��3��69   �� 5F  &   $��AI��6,   $��0��5G  ,   $��4��69   �� 5I  &   $��U��6,   $��0��5J  ,   $��5��69   �� 5L  &   $��	txtNombre��6.   $��1��5M  .   $��0��6;   �� 5O  &   $��cmbBox��6/   $��1��5P  /   $��1��6<   .@�5Q  *   �� .��67   Numero6?   �� 5R  *   .��67   Texto6>   5S  '   �� 5U  &   $��chkNN��6/   $��1��5V  /   $��2��6<   �� 5X  &   $��chkPK��6/   $��1��5Y  /   $��3��6<   �� 5\  &   $��chkAI��6/   $��1��5]  /   $��4��6<   �� 5_  &   $
��chkU��6/   $��1��5`  /   $��5��6<   5c  #   5d     5g     5j     5k     5l     5m     5n     