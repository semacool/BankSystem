   M S B A M L   `   `   `  ����L  HBankSystemDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BankSystemDesktop.ViewsBankSystemDesktop.Views  5   	   *    $BankSystemDesktop.Views.CreditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BankSystemDesktop.Views     5   	     � Title$  CreditWindow��5   	   $	��202��6   $	��688��6+    � 	Resources 5	       �� 
TargetType   TBStyle �� Property �� Value  SliderStyle  ButtonStyle  ComboBoxStyle��%�  &	        &	 ~     &	 �     &	     �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   6C   �� 5       � ��$ Center=�64   6E   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  � ��$ 15q�6'   64   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   6C   �� 5       � ��$ 10q�6'   64   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��157* �6   �� 5      $	��43* �6    � RowDefinitions 5   
   �� 5       $
��100* �6   �� 5!      $	��65* �6   .+�5#   
   �� $��Настройки��6   $��2��6&   .��5$      �  5%      �� 5&      $
��177* �6$   �� 5'      $
��169* �6$    5)      �� 5*      $
��127* �6'   �� 5+      $
��489* �6'   .+�5.      �� #��[  6   $��0��6m   ��6=   �� *Money+ �� StringFormat$ Взять: {0}��6|   �� 5/      #��[  6   $��1��6j   ��6=   �� *Year+$ Лет: {0}��6y   �� 50      #��[ 6   $��0��6V   $��1��6c    � Maximum$ 5000000Q�6s   	 � Minimum$	 300000Q�6�   
 �� Orientation$
 
Horizontal=�6�    � Value 6>   �� *Money+6�   �� 51      #��[ 6   $��1��6U   $��1��6b   $	 1Q�6r    6>   �� *Year+6�   52      53      �� 54   
   #��[ 6   $��1��6:   ��6G   �� *Rates+ �� SelectedValue 6e   �� *
SelectRate+��55      �� 56      .R�57      ��  �� Orientation$ 
Horizontal=�6!   .+�58      �� $��0,0,20,0q�6:   ��6$   �� *Name+6N   �� 59      ��6$   �� *	Percent+$
 %{0}��6Q   5:      5;      5=      �� 5?   
   -   5        #��[ 5?   1   $��1��6V   $��1��6f   $��Взять кредит��6s   {�6   �� *	EnableBut+6�   5@      5A      