   M S B A M L   `   `   `  ����H  DCovid19Berlin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Covid19BerlinCovid19Berlin  5   	       Covid19Berlin.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Covid19Berlin     5   	   -   5          � Title$  Covid19 in Berlin��5   	   $	��650��5	   	   $
��1200��5
   	   $	��650��5   	   $	��600��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $
��Left=�6   $��Center=�60   .+�5      >� $	��250��6   $	��250��6'   
�������$��2q�6F   $
��Left=�6Z   $��	20,0,0,20q�6u   $��Stretch=�6�   .��5      �� -   5         ��Name$ pnlBerlinGesamt��5      .+�5      �� $��Gesamtzahl Berlin��6   $��	0,20,0,20q�68   $��18(�6K   $
��Bold"�6Y   $��Center=�6k   �� 5      $��
Fallzahlen��6   $
��Bold"�61   $��Center=�6C   $��	0,-10,0,0q�6`   �� 5      -   5         ��Name$ lblGesFallzahlen��5      $��Center=�66   $��	0,-10,0,0q�6S   �� 5      $��	Differenz��6   $
��Bold"�60   $��Center=�6B   �� 5      -   5        $ lblGesDifferenz��5      $��Center=�65   $��	0,-10,0,0q�6R   �� 5      $��Inzidenz��6   $
��Bold"�6/   $��Center=�6A   �� 5      -   5        $ lblGesInzidenz��5      $��Center=�64   $��	0,-10,0,0q�6Q   �� 5      $��Genesen��6   $
��Bold"�6.   $��Center=�6@   �� 5       -   5        $ lblGesGenesen��5       $��Center=�63   $��	0,-10,0,0q�6P   5!      5"      >� 5#      $	��250��6   $	��250��6'   
�������$��2q�6F   $
��Left=�6Z   $��20,0,0,0q�6u   $��Bottom=�6�   .��5$      �� -   5        $ pnlAktuellerBezirk��5$      .+�5%      �� -   5        $ lblBezirkname��5%      $��	0,20,0,20q�63   $��[Bezirk]��6F   $��17(�6Y   $
��Bold"�6g   $��Center=�6y   �� 5'      $��
Fallzahlen��6   $
��Bold"�61   $��Center=�6C   $��	0,-10,0,0q�6`   �� 5(      -	   5        $ lblFallzahlen��5(      $��Center=�63   $��	0,-10,0,0q�6P   �� 5*      $��	Differenz��6   $
��Bold"�60   $��Center=�6B   �� 5+      -
   5        $ lblDifferenz��5+      $��Center=�62   $��	0,-10,0,0q�6O   �� 5-      $��Inzidenz��6   $
��Bold"�6/   $��Center=�6A   �� 5.      -   5        $ lblInzidenz��5.      $��Center=�61   $��	0,-10,0,0q�6N   �� 50      $��Genesen��6   $
��Bold"�6.   $��Center=�6@   �� 51      -   5        $ 
lblGenesen��51      $��Center=�60   $��	0,-10,0,0q�6M   52      53      54      �� 55   
   -   5        $ pnlKarte��55      $��Center=�6'   $��Center=�6B   .+�56      >� 
�������$��2q�6-   $��Stretch=�6A   $��Stretch=�6]   $��300,50,300,50q�6{   .��57      �� $#��./ressources/berlin_karte.png��6   $
��Fill=�6?   58      59      �� 5:   
   $��Right=�6   $��Center=�61   .+�5;      >� $	��520��6   $	��250��6'   
�������$��2q�6F   $��Center=�6Z   $��0,0,20,0q�6w   $��Center=�6�   .��5<      �� -   5        $ pnlListeAlleBezirke��5<      .+�5=      �� $��0,20,0,0q�6   $��Bezirke��6.   $��18(�6@   $
��Bold"�6N   $��Center=�6`   5>      5?      5@      5A      5B      