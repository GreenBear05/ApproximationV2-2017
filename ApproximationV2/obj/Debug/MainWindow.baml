   M S B A M L   `   `   `  ����J  FApproximationV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ApproximationV2ApproximationV2  5   	        ApproximationV2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ApproximationV2     5   	     � Title$  
MainWindow��5   	   $	��403��6   $	��590��6)    � 	Resources 5	         DataTemplatePoint ��Name J� RenderTransformOrigin �� Left
 �� Top
 � Tag ��Name �� TextWrapping	 �� Mode
 ��Name��%u  &	        �� 5
   
   .R�5      �� $
��Left=�6   $	��150��6-   $	��Top=�6;   #��� ��6S   .+�5      �� $ buttonRemove��6.   -   5        $��Удалить��5   D   $
��Left=�6V   $	��Top=�6q   $��75��6�   $��20��6�   $ 0.76,0.3&�6�   $ 43��6�   $	 120��6�    6   �� *Self+6�   �� 5      $ 	buttonAdd��6.   -   5        $��Добавить��5   A   $
��Left=�6T   $	��Top=�6o   $��75��6�   $��20��6�   $ 43��6�   $ 95��6�    6   �� *Self+6�   �� 5      $ 	TextBox_X��6:   $
��Left=�6M   $��23��6h   $
 Wrap=�6t   $	��Top=�6�   $��92��6�   $ 40��6�   $ 13��6�   ��6   �� *X+$	 TwoWay=�6�   �� 5      $ 	TextBox_Y��6:   $
��Left=�6M   $��23��6h   $
 Wrap=�6t   $	��Top=�6�   $��92��6�   $ 40��6�   $ 50��6�   ��6   �� *Y+$	 TwoWay=�6�   �� 5      $
 labelX��6   $��X��6$   $
��Left=�60   $	��Top=�6K   $ 3.588,1.231&�6c   $ 10��6�   $ 10��6�   �� 5      $
 labelY��6   $��Y��6$   $
��Left=�60   $	��Top=�6K   $ 10��6c   $ 47��6t   $ -0.353,1.115&�6�   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ ListBox_Points��5      #���   6*    %� 
ScrollUnit$ Pixel=�6]   $
��Left=�6�   $��5,5,0,5q�6�   $	��260��6�   $��1��6�   �� 5   
   -   5        $ ButtonStart��5      $��Пуск��6&   $
��Left=�65   $��402,320,0,0q�6P   $	��Top=�6e   $��75��6}   $��1��6�   $��20��6�   6�   5      5      