   M S B A M L   `   `   `  ����J  FLibrary_Student, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_StudentLibrary_Student  5   	   $    Library_Student.PasswordUpdate   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library_Student     5   	     � Title$  PasswordUpdate��5   	   $	��250��6    $	��400��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��80 �6   6*   �� 5      $��* �6   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $	��0 5q�6   $��Şifremi Güncelle��6!   $��2��69   $��20(�6M   $
��Bold"�6[   $
��Left=�6m   $	��Top=�6�   ���	#FFEC0E0E6�   �� 5   
   $��Eski Şifre��6   $��1��6'   $��0��64   $	��0,5q�6D   6T   �� 5   
   -   5         ��Name$ txtOldPassword��5      $��1��6*   $��1��67   $��2��6G   $	��0,5q�6[   6j   �� 5   
   $��Yeni Şifre��6   $��2��6'   $��0��64   $	��0,5q�6D   6T   G� 5   
   -   5         G�Name$ txtNewPassword��5      $��2��6.   $��1��6;   $��2��6K   $	��0,5q�6_    G� PasswordChar$ *��6l   6   �� 5   
   $��Yeni Şifre Tekrar��6   $��3��6.   $��0��6;   $	��0,5q�6K   6[   G� 5   
   -   5        $ txtNewPassword1��5      $��3��6/   $��1��6<   $��2��6L   $	��0,5q�6`   $ *��6m   6�   �� 5!   
   -   5         ��Name$ 	btnUpdate��5!      $��	Güncelle��6$   $��4��67   $��1��6D   $��0,10,0,0q�6T   6f   5#      5$      