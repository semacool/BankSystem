   M S B A M L   `   `   `  ����L  HBankSystemDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BankSystemDesktop.ViewsBankSystemDesktop.Views  5   	   -    'BankSystemDesktop.Views.AddClientWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BankSystemDesktop.Views     5   	     � Title$  AddClientWindow��5   	   $	��390��6!   $	��502��6.    � 	Resources 5	       �� 
TargetType   TBStyle �� Property �� Value  ButStyle��%�   &	        &	 Q     �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  � ��$ 30q�6'   64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��60* �6   �� 5      $	��59* �6   �� 5      $	��63* �6   �� 5      $	��67* �6   �� 5      $
��125* �6    � ColumnDefinitions 5   
   �� 5      $
��140* �6   .+�5   
   �� $��ФИО��6   $��0��6    .��5      �� -   5         ��Name$ NameTb��5      #��[  6&   6I   5      �� 5    
   $��Контакты��6   $��1��6%   .��5!      �� -   5        $ 
ContactsTb��5!      #��[  6*   6M   5"      �� 5#   
   $��
Логин��6   $��2��6"   .��5$      �� -   5        $ LoginTb��5$      #��[  6'   6J   5%      �� 5&   
   $��Пароль��6   $��3��6#   .��5'      �� -   5        $ 
PasswordTb��5'      #��[  6*   6M   5(      �� 5*   
   -   5        #��[ 5*      $��Создать��63   $��4��6E   6l   5+      5,      