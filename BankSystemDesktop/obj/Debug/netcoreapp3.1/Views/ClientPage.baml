   M S B A M L   `   `   `  ����L  HBankSystemDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BankSystemDesktop.ViewsBankSystemDesktop.Views  5   	   (    "BankSystemDesktop.Views.ClientPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BankSystemDesktop.Views     5   	     � Title$  
ClientPage��5   	   $	��450��6   $	��400��6)    � 	Resources 5	       �� 
TargetType   Text �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   6C   �� 5       � ��$ Center=�64   6E   �� 5       � ��$ 	30,0,30,0q�6'   6;   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��41* �6   �� 5      $	��50* �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $
��383* �6   .+�5   
   �� #��[  6   $��CharacterEllipsis=�6f   $��0��6�   ��62   �� *Client.Name+ �� StringFormat$ Фио: {0}��6�   �� 5   
   #��[  6   $��CharacterEllipsis=�6o   $��1��6�   ��62   �� *Client.Contacts+$ Контакты: {0}��6�   �� 5   
   #��[  6   $��2��6c   ��62   �� *	Client.Id+$ Id: {0}��6v   �� 5    
   $��3��6   $��1��6)   .@�5!      �� $��Депозиты��6   .��5"      �� -   5         ��Name$ DepositsList��5"      ��61   �� *
Deposits+	 �� View	 5#      �� 5$      P�5%      �� 5&   "   $��Код��61   
 �� DisplayMemberBinding
 6>   �� *Id+6d   �� 5'   "   $��Деньги��61   
 6A   �� *Money+6j   �� 5(   "   $��Дата октрытия��61   
 6H   �� *DateCreated+6w   �� 5)   "   $#��Дата начилсения��61   
 6J   �� *
NextUpdate+6x   �� 5*   "   $��Дата закрытия��61   
 6H   �� *	DateEnd+6s   �� 5+   "   $��
Тариф��61   
 6@   �� *	Rate.Name+6m   5-      5/      50      �� 51      $��Кредиты��6   .��52      �� -   5        $ CreditsList��52      ��60   �� *	Credits+	 53      �� 54      P�55      �� 56   "   $��Код��61   
 6>   �� *Id+6d   �� 57   "   $��Деньги��61   
 6A   �� *Money+6j   �� 58   "   $��Долг��61   
 6?   �� *Dept+6g   �� 59   "   $��Дата октрытия��61   
 6H   �� *DateCreated+6w   �� 5:   "   $#��Дата начилсения��61   
 6J   �� *
NextUpdate+6x   �� 5;   "   $��Дата закрытия��61   
 6H   �� *	DateEnd+6s   �� 5<   "   $��
Тариф��61   
 6@   �� *	Rate.Name+6m   5>      5@      5A      5C      5E      5F      