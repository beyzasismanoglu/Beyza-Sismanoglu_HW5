   M S B A M L   `   `   `  ����J  FLibrary_Student, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library_StudentLibrary_Student  5   	   !    Library_Student.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library_Student     5   	     � Title$  LoginWindow��5   	   $	��250��6   $	��400��6*   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��80 �6   6*   �� 5      $��* �6   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $	��0 5q�6   $-��'Giriş Yapmak için Bilgilerinizi girin��6!   $��2��6N   $��20(�6b   $
��Bold"�6p   $
��Left=�6�   $	��Top=�6�   ���	#FFEC0E0E6�   �� 5   
   $��Kullanıcı Adı��6   $��1��6*   $��0��67   $	��0,5q�6G   6W   �� 5   
   -   5         ��Name$ txtUserName��5      $��1��6'   $��1��64   $��2��6D   $	��0,5q�6X   6g   �� 5   
   $	��0 5q�6   $��Şifre��6!   $��2��6.   $��0��6;   6O   G� 5   
   -   5         G�Name$ txtPassword��5   #   $	��0 5q�6   $��2��68   $��1��6E   $��2��6U    G� PasswordChar$ *��6i   6}   �� 5   
   -   5         ��Name$ btnLogin��5      $��
Giriş Yap��6#   $��3��67   $��1��6D   $��0,10,0,0q�6T   6f   5!      5"      