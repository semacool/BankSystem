   M S B A M L   `   `   `  ����L  HBankSystemDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BankSystemDesktop.ViewsBankSystemDesktop.Views  5   	   +    %BankSystemDesktop.Views.AddRateWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BankSystemDesktop.Views     5   	     � Title$  AddRate��5   	   $	��308��6   $	��387��6&    � 	Resources 5	       �� 
TargetType   Text �� Property �� Value  TBStyle  CBStyle  ButStyle��%�  &	        &	 ~     &	 �     &	      �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   6C   �� 5       � ��$ Center=�64   6E   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��26* �6   �� 5      $	��34* �6   �� 5      $	��33* �6   �� 5      $	��28* �6   .+�5!   
   �� $!��Кредит/Депозит��6   $��0��6+   .��5"      �� #��[ 6   ��68   �� *	TypeRates+ �� SelectedItem 6Z   �� *
SelectRate+5#      5$      �� 5%   
   $��Название��6   $��1��6%   .��5&      �� #��[ 6   ��67   �� *Name+6O   5'      �� 5(   
   $��Процент��6   $��2��6$   .��5)      �� #��[ 6   ��67   �� *	Percent+6R   5*      �� 5+   
   $/��)Частота капитализации��6   $��3��62   .��5,      ��  �� Orientation$ Vertical=�6   .+�5-      ��  � Maximum$ 60Q�61   	 � Minimum$	 1Q�6>   
 � SmallChange$
 1Q�6J    � Value 6   �� *Month+6]   �� 5.      #��[  6   ��6:   �� *Month+ �� StringFormat$ Месяцев: {0}��6n   5/      50      �� 52   
   -   5        #��[ 52      $��4��63   $��Добавить��6@   6k   53      54      