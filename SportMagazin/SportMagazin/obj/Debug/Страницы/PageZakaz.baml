   M S B A M L   `   `   `  ����G  CSportMagazin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SportMagazin.СтраницыSportMagazin.Страницы  5      -    'SportMagazin.Страницы.PageZakaz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:SportMagazin.Страницы     5        N� Title$  	PageZakaz��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��17* �6   �� 5      $
��172* �6   �� 5      $	��21* �6   .+�5   
   �� $��
Заказ��6   $��Center=�6!   $��Center=�6>   $��385,7,384,7q�6Y   �� 5   
   -   5         ��Name$ btNazad��5      $��1��6"   $��Right=�6/   $��
Назад��6K   6[   �� 5   
   -   5         ��Name$ lbTovar��5      $��2��6#   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��100 �6/   �� 5      $
��300* �6/   �� 5      $
��300* �6/   .+�5      �� $��0��68   $��5q�6H   ��6    �� *Foto+6H   �� 5       �� Orientation$ Vertical=�6%   $��1��6<   $��5q�6L   .+�5      �� ��6(   �� *
Nazvanie+�� 5       ��6(   �� *
Opisanie+ �� StringFormat$ Описание: {0}���� 5!      ��6(   �� *Proizvoditel.Nazvanie+$% Производитель: {0}���� 5"      ��6(   �� *Cena+$ Цена: {0}руб.��5#      �� 5$      $ btDobavlenieVZakaz��6!   $$��Добавить в заказ��6=   $��Center=�6X   $��Center=�6u   $��2��6�   5%      5&      5(      �� 5)   
   -   5        $ btnSave��5)      $��Сохранить��6"   $��Center=�66   $��Center=�6S   $��3��6n   6{   5*      5+      