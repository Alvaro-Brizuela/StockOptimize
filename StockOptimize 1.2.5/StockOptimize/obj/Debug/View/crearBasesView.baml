   M S B A M L   `   `   `  ����H  DStockOptimize, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StockOptimize.ViewStockOptimize.View  5   	   '    !StockOptimize.View.crearBasesView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:StockOptimize.View     5   	     � Title$  Bases de Datos��5   	   $
��1080��6    $
��1920��6.    � WindowStyle$ SingleBorderWindow=�5	   	    � 
ResizeMode$ 	CanResize=�6*    � Icon$  Imagenes/base-de-datos.ico��5
   	   .��5      �� ��5   
   �� 5       �� 
StartPoint$	 0,1&�6"    �� EndPoint$	 1,0&�63   .��5      �  � Color$ #060531��6    � Offset$ 0Q�6/   � 5      $ #1B1448��6   $ 1Q�6/   5      ._�5   
   �  � RowDefinitions 5      �� 5      $��70 �6    �� 5      $	��200 �6    �� 5      �� 5      .+�5      � $��1��6   	 � ColumnDefinitions	 5      �� 5      $	��120 �6'   �� 5       �� 5!      $	��100 �6'   .+�5$      �� -   5        $��btnCerrarSesion��5)      $��2��5$      $��Cerrar Sesión��5%      $��
Montserrat)�5&      $��0,10,0,0q�5'      
�������
 � Cursor$

 Hand��5*      ��5,      �� 5-       �� 
TargetType" ��6    .�5.      ��  �� Property � �� �� Value �#462AD86;    �� Triggers 5/      P� 50   "    P� Property �@J�IsMouseOver P� Value . . �51   &   ��  � �� �#28AEED6C   52   #   54      ��57      �� 58       �� 
TargetType" ��6*   .R�59      �� $	��100��6%   $��50��61    �� CornerRadius$ 20��5:   %   #��z��5;   %   ._�5<   "   �� $��Center=�63   $��Center=�5=   3   5>      5?      5A      �� 5B      -   5        $��	btnVolver��5G      $��0��5B      $��Volver��5C      $��
Montserrat)�5D      $��0,10,0,0q�5E      
�������$

 Hand��5H      ��5J      �� 5K      " ��6    .�5L      ��  � �� �#462AD86;    5M      P� 5N   "    �@J�IsMouseOver . . �5O   &   ��  � �� �#28AEED6C   5P   #   5R      ��5U      �� 5V      " ��6*   .R�5W      �� $	��100��6%   $��50��61   $ 20��5X   %   #��z��5Y   %   ._�5Z   "   �� $��Center=�63   $��Center=�5[   3   5\      5]      5_      5`      �� 5b      $��1��6   $��0,40,0,0q�6&   $	��Top=�68   $��Center=�6P   .+�5c      �� $��2q�6   $ 10��5d      ��5f      �� 5g      $	 0,0&�6.   $	 1,1&�6?   .��5h      � $ #462AD8��6+   $ 0Q�6;   � 5i      $ #DA34AE��6+   $
 0.75Q�6;   � 5j      $ #8A16C1��6+   $ 1Q�6;   5k      ._�5n      �� .+�5o      �� $��Nombre Tabla��6$   
�������$��
Montserrat)�5q   $   $��20(�5r   $   $��20,20,20,10q�5s   $   $��Medium"�5t   $   �� 5v      
�������$��2q�5w   !   $ 5��5x   !   $��
20,0,20,20q�5y   !   ._�5{      �� -   5        $��txtTabla��5{   &   $
��1000��5|   &   $
��Left=�5}   &   $��35��5~   &   $��15(�5   &   $��
Montserrat)�5�   &   
������� �� 
CaretBrush
 �����
������ $��0q�5�   &   $��Bottom=�5�   &   $��Center=�5�   &   $��0,0,0,0q�5�   &   67   5�      5�      5�      5�      �� 5�      $��2��6   $��2q�5�      $ 10��5�      $��10,10,10,10q�5�      $��2��6*   ��5�      �� 5�      $	 0,0&�6*   $	 1,1&�6;   .��5�      � $ #462AD8��6'   $ 0Q�67   � 5�      $ #DA34AE��6'   $
 0.75Q�67   � 5�      $ #8A16C1��6'   $ 1Q�67   5�      ._�5�      �  5�      �� 5�      $��80 �6(   �� 5�      .+�5�      � $��0��6   	 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $��
btnAñadir��5�   !   $��0��5�   !   $��	+ Añadir��5�   !   
�������$��
Montserrat)�5�   !   $

 Hand��5�   !   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�      #��z��5�      ._�5�   *   �� $��Center=�6;   $��Center=�5�      5�   '   5�   #   5�      �� 5�      -   5        $��btnEliminar��5�   	   $��1��5�   !   $��
- Eliminar��5�   	   
�������$��
Montserrat)�5�   	   $

 Hand��5�   	   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�   ,   #��z��5�   ,   ._�5�   *   �� $��Center=�6;   $��Center=�5�   ;   5�   '   5�   #   5�      �� 5�      -   5        $��btnMoverPrincipio��5�   !   $��2��5�   !   $��⏫ Mover al principio��5�   !   
�������$��
Montserrat)�5�   !   $

 Hand��5�   !   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � �� �#462AD86C    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#28AEED6K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� $	��200��6-   $��50��69   $ 20��5�      #��z��5      ._�5  *   �� $��Center=�6;   $��Center=�5     5  '   5  #   5     �� 5	     -   5        $��btnMoverArriba��5  	   $��3��5	  !   $��🔼 Mover arriba��5
  	   
�������$��
Montserrat)�5  	   $

 Hand��5  	   ��5     �� 5  "   " ��6(   .�5  &   ��  � �� �#462AD86C    5  &   P� 5  *    �@J�IsMouseOver . . �5  .   ��  � �� �#28AEED6K   5  +   5  #   ��5     �� 5  "   " ��62   .R�5  &   �� $	��200��6-   $��50��69   $ 20��5     #��z��5     ._�5   *   �� $��Center=�6;   $��Center=�5!     5"  '   5#  #   5&     �� 5(     -   5        $��btnMoverAbajo��5-  	   $��4��5(  !   $��🔽 Mover Abajo��5)  	   
�������$��
Montserrat)�5+  	   $

 Hand��5,  	   ��5/     �� 50  "   " ��6(   .�51  &   ��  � �� �#462AD86C    52  &   P� 53  *    �@J�IsMouseOver . . �54  .   ��  � �� �#28AEED6K   55  +   57  #   ��5:     �� 5;  "   " ��62   .R�5<  &   �� $	��200��6-   $��50��69   $ 20��5=     #��z��5>     ._�5?  *   �� $��Center=�6;   $��Center=�5@     5A  '   5B  #   5E     �� 5G     -	   5        $��btnMoverFinal��5L  	   $��5��5G  !   $��⏬ Mover al final��5H  	   
�������$��
Montserrat)�5J  	   $

 Hand��5K  	   ��5N     �� 5O  "   " ��6(   .�5P  &   ��  � �� �#462AD86C    5Q  &   P� 5R  *    �@J�IsMouseOver . . �5S  .   ��  � �� �#28AEED6K   5T  +   5V  #   ��5Y     �� 5Z  "   " ��62   .R�5[  &   �� $	��200��6-   $��50��69   $ 20��5\     #��z��5]     ._�5^  *   �� $��Center=�6;   $��Center=�5_     5`  '   5a  #   5e     5f     �� 5i     -
   5        $��lbTabla��5i     $��1��6.   
������ $��	57,0,0,10q�6   $
��Left=�6�    � 	Resources 5j     ��%�  '��       '�� �     �� 5k     " ��6$   .�5l  "   ��  � �� �#462AD86?   �� 5m  "    � ��$ 
Montserrat)�6?   �� 5n  "    � ��
 �����6?   �� 5o  "    �@J�IsHitTestVisible .  6E   �� 5p  "    � ��$ 20(�6=   5q     �� 5r     " ��6$    5s  "   P� 5t  &    �@��
IsSelected . . �5u  *   ��  � ��
 ���� 6G   5v  '   P� 5w  &    �@J�IsMouseOver . . �5x  *   ��  � ��
 ���� 6G   5y  '   5{     5|      �� View 5}     �� 5~      �� AllowsColumnReorder .  .P�5  "   �� $��Nombre��61    �� Width$	 250��6A    �� CellTemplate 5�  &   �� 5�  *   .R�5�  .   �� $��Center=�6N   $��Center=�6i   
�������
������ $��16(�6�   ��66   �� *Nombre+6�   5�  +   5�  #   �� 5�  "   $
��Tipo��61   $	 150��6?    5�  &   �� 5�  *   .R�5�  .   �� $��Center=�6U   $��Center=�6p   $��16(�6�    �� SelectedItem 67   �� *Tipo+.@�5�  2   �� .��6?   Texto6F   �� 5�  2   .��6?   Entero6G   �� 5�  2   .��6?   	Decimal6H   �� 5�  2   .��6?   Numero6G   5�  /   5�  +   5�  #   �� 5�  "   $��NN��61   $	 100��6=    5�  &   �� 5�  *   .R�5�  .   �� $��Center=�6P   $��Center=�6k    d� 	IsChecked 67   �� *NN+6k   5�  +   5�  #   �� 5�  "   $��PK��61   $	 100��6=    5�  &   �� 5�  *   .R�5�  .   �� $��Center=�6P   $��Center=�6k    67   �� *PK+6k   5�  +   5�  #   �� 5�  "   $��AI��61   $	 100��6=    5�  &   �� 5�  *   .R�5�  .   �� $��Center=�6P   $��Center=�6k    67   �� *AI+6k   5�  +   5�  #   �� 5�  "   $��U��61   $	 100��6<    5�  &   �� 5�  *   .R�5�  .   �� $��Center=�6O   $��Center=�6j    67   �� *U+6j   5�  +   5�  #   5�     5�     �� 5�     -   5        $��btnActualizar��5�     $��Crear tabla��5�     $
��Left=�5�     $��	872,0,0,0q�5�     $��1��5�     $	��Top=�6*   $��84��5�     $	��256��6)   $��
Montserrat)�5�     
�������$

 Hand��5�     ��5�     �� 5�     " ��6$   .�5�  "   ��  � �� �#462AD86?    5�  "   P� 5�  &    �@J�IsMouseOver . . �5�  *   ��  � �� �#28AEED6G   5�  '   5�     ��5�     �� 5�     " ��6.   .R�5�  "   �� $	��200��6)   $��50��65   $ 20��5�  ,   #��z��5�  ,   ._�5�  &   �� $��Center=�67   $��Center=�5�  ;   5�  #   5�     5�     5�     5�     5�     5�     5�     