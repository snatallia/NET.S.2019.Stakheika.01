   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.1, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     � Title$  Animal Info��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��100 �6   .+�5   
   �� -   5        $��lblInfo��5      $��0��6   $��
20,20,0,20q�6,   $��16(�6@   .��6N   Info abount animal:6d   �� 5   
   -   5        $��	lblAnimal��5   .   $��1��6   $��5��6   $��
20,40,0,20q�6?   $��16(�6S   .��6a   text6g   �� 5   
   -   5        $��btnEat��5   ;   $��1��6   $��1��6   $	��0,0q�6.    � Cursor$
 Hand��6I   $	��Eat��6n   �� 5   
   -   5        $��btnWalk��5   ;   $��2��6   $��1��6   $	��0,0q�6.   $
 Hand��6J   $
��Walk��6p   �� 5   
   -   5        $��btnGrowl��5   ;   $��3��6   $��1��6   $	��0,0q�6.   $
 Hand��6K   $��Growl��6r   5      5      