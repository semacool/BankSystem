   M S B A M L   `   `   `  ����L  HBankSystemDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BankSystemDesktop.ViewsBankSystemDesktop.Views  5   	   *    $BankSystemDesktop.Views.WorkerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BankSystemDesktop.Views     5   	   -   5          � Title$  WorkerWindow��5   	   $	��450��6   $	��800��6+    � 	Resources 5	      3   -BankSystemDesktop.Views.SelectToBoolConverter   SelectToBoolConverter �� 
TargetType  Text �� Property �� Value 	 Input��%   &	        &	      &	 �       5
   
   6&   �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   6E   �� 5       � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��47* �6   �� 5      $
��164* �6   �� 5      $
��223* �6   .+�5   
   �� $��Рабочий��6   .��5      �  � ColumnDefinitions 5      �� 5      6)   �� 5      6)   �� 5      6)   �� 5       6)   .+�5"      �� #��[ 6   $��Имя:��6:   6H   �� 5#      #��[ 6   $��1��69   ��6I   �� *Worker.Name+6h   �� 5$      #��[ 6   $��3��6k   ��6:   �� *	Worker.Id+ �� StringFormat$ Id: {0}��6}   5%      5&      �� 5'   
   $��Клиенты��6   $��1��6$   .��5(      �� ��6   �� *	Clients+ �� SelectedItem 67   �� *SelectClient+	 �� View	 5)      �� 5*      P�5+      �� 5,      $��Id��6-   
 �� DisplayMemberBinding
 69   �� *Id+6_   �� 5-      $��Имя��6-   
 6:   �� *Name+6b   �� 5.      $��Контакты��6-   
 6?   �� *
Contacts+6k   50       � ContextMenu 52      �� 53      .@�54      m� -   5        $��Добавить��54   #   6O   m� 55      -   5        $��Подробнее��55   x   {�6#   �� *SelectClient+ �� 	Converter# [  6�   56      58      59      �� 5:   
   $��Тарифы��6   $��2��6#   .��5;      �� ��6   �� *Rates+ 65   �� *
SelectRate+	 5<      �� 5=      P�5>      �� 5?      $��Id��6-   
 69   �� *Id+6_   �� 5@      $��Тип��6-   
 6:   �� *
TypeRate+6f   �� 5A      $��Название��6-   
 6?   �� *Name+6g   �� 5B      $��Процент��6-   
 6>   �� *	Percent+6i   �� 5C      $%��Частота расчтёта��6-   
 6G   �� *TimeForNext+6v   �� 5D      $��Активен��6-   
 6>   �� *Active+6h   5F       5H      �� 5I      .@�5J      m� -   5        $��Добавить��5J   #   6M   m� 5K      -   5        $"��Деактивировать��5K   v   {�6#   �� *
SelectRate+# [  6�   5L      5O      5P      5Q      5R      