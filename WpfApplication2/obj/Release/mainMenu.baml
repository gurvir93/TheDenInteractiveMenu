   M S B A M L   `   `   `  ����   WpfApplication2    WpfApplication2.mainMenu   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � 	Resources     UserTemplate � ColumnDefinitions � RowDefinitions �� StringFormat ��Name �� ImageSource ��Name �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName K� ZIndex K� IsItemsHost �Name ��Name �� Padding��%�  &	        '�� �    '�� f    '�� O    �� .R�� $	��0,2q����� *Disable_colour+ �� $��20 ��� $	��147 ��� $��50 ��� $��20 � �� $��20 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��0������ *
Quantity+�� $��0��$��1������ *
DishName+�� $��0��$��2������ *Price+$ C2���� $ x_Button��-   $��x��$��0��$��3��
�������$��Khmer UI)�$��16(�y��� *Button+��Z� ���� $ button2.png���� $ ingredient1��$��1��$��1��
���  ������ *Ingredients[0]+y��� *Visibility[0]+�� $ ingredient2��$��2��$��1��
���  ������ *Ingredients[1]+y��� *Visibility[1]+�� $ ingredient3��$��3��$��1��
���  ������ *Ingredients[2]+y��� *Visibility[2]+�� $ ingredient4��$��4��$��1��
���  ������ *Ingredients[3]+y��� *Visibility[3]+�� $ ingredient5��$��5��$��1��
���  ������ *Ingredients[4]+y��� *Visibility[4]+�� $ ingredient6��$��6��$��1��$�� ��$y�	Collapsed=�
���  ���� $ ingredient7��$��7��$��1��$�� ��$y�	Collapsed=�
���  ���� " ��.���  � ��	 �� "
 ��.R�� .+��� $��Border�����#292421
���   �$��1,1,1,1q�$ 6,6,0,0��._��� $ ContentSite��$��Center=�$��Center=�$��Header��$��	12,2,12,2q� P�  �@��
IsSelected . . ��� $ Border�� � ��	 �#292421�� $ ContentSite�� � ��$
	 Bold"��� $ ContentSite�� � ��	 �#F4A460P�  �@��
IsSelected .  . ��� $ Border�� � ��	 �� $ tab2.png���� " ��.���  � ��	 �� "
 ��.R��  �� $
��Auto ��� $��* �.+��� $��0��$ 1��$��0,0,4,-1q� . 
������ �� $��1��$��1q�$ 0, 12, 12, 12�����#292421��Z� ._��� $��SelectedContent���� " ��.���  � ��	 �� "
 ��.R�� $
 Grid��.+��� $ Border��#��z��#��z��#��z��# z���� #��z��#��z��#��z����.  P�  � �� . . ��� $ Border�� � ��	 �� $ button1.png���� $ Border�� � ��	 �� $ button2.png��.��� -   $��grid_mainMenu�� �� $
��1050 ��� $	��316 �.+��� -   $��tabcontrol_Main��$
��Left=���Z� ��Z� ��Z� .@��� -   $��tab_specials��$��Specials��$��Khmer UI)�$	��116��$��40�� �� 
IsSelected . 
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q� �� Orientation$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=� �� PanningMode$ HorizontalOnly=�$	��714��.��� -   $ menu_specials�� �� $	��350 ��� $	��350 ��� $��	Beverages��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -   $ menu_beverages�� �� $	��350 ��� $	��350 ��� $��
Appetizers��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -   $ menu_appetizers�� �� $	��350 ��� $	��350 ��� $��Salads��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -   $ menu_salads�� �� $	��350 ��� $	��350 ��� $��Pizza��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -	   $ 
menu_pizza�� �� $	��350 ��� $	��350 ��� $��Burgers��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -
   $ menu_burgers�� �� $	��350 ��� $	��350 ��� $��Poutine��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -   $ menu_poutine�� �� $	��350 ��� $	��350 ��� $��Desserts��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -   $ menu_desserts�� �� $	��350 ��� $	��350 ��� $��	All Items��$	��116��$��40��$��Khmer UI)�
�������$��15(���Z� ���� $ tab2.png��.���� $��0,0,0,6q�$ Vertical=�.+��� ��. $
��Auto=�$��Disabled=�$ HorizontalOnly=�$	��714��.��� -   $ menu_all�� �� $	��350 ��� $	��350 ��� $��1��$��Center=�$��
10,10,10,0q�$	��Top=�.+��� $ 
Horizontal=�.+��� -    ��Name$ textbox_searchBar��$��24(�$��Khmer UI)�$
��Left=�$��34�� �� TextWrapping$
 Wrap=�$��	Search...��$	��180���� -   $��Search��$��68��
���������Z� ���� $ button2.png��9� -   $��Filter��$��20(�$��	0,10, 0,0q�$��Khmer UI)�
�������.���� .+��� -    ��Name$ checkbox_veggie��$��
Vegetarian��$��14(� d� 	IsChecked$
 TrueY�$��Khmer UI)�
������� � LayoutTransform ��  �� ScaleX$	 1.5Q� �� ScaleY$	 1.5Q��� -   $ checkbox_vegan��$��Vegan��$��14(�$
 TrueY�$��Khmer UI)�
������� �� $	 1.5Q�$	 1.5Q��� -   $ checkbox_chicken��$��Chicken��$��14(�$
 TrueY�$��Khmer UI)�
������� �� $	 1.5Q�$	 1.5Q��� -   $ checkbox_beef��$
��Beef��$��14(�$
 TrueY�$��Khmer UI)�
������� �� $	 1.5Q�$	 1.5Q��� -   $ checkbox_seafood��$��Sea Food��$��14(�$
 TrueY�$��Khmer UI)�
������� �� $	 1.5Q�$	 1.5Q��� -   $ checkbox_peanut��$
��Pork��$��14(�$
 TrueY�$��Khmer UI)�
������� �� $	 1.5Q�$	 1.5Q��� $��Order��$��0,10,0,0q�$��Khmer UI)�
�������$��20(�� $��1��$
��Left=�$	��435��$��0,0,0,0q�$	��Top=�$	��247��.+��� -   $��listbox_order��#��[  $��Stretch=�$��Hidden=�$��Hidden=����� �� $��1��$
��Left=�$��
30,560,0,0q�$	��Top=�$	��158��.+��� $ 
Horizontal=�.+��� -   $��label_total��$��Total:��$��16(�$��Khmer UI)�
�������$	��160���� -   $��label_price_total��$��$ 0.00��$��16(�$��Khmer UI)�
�������$��90��$��Right=��� -   $ button_order��$��
Send Order��$��Khmer UI)�$	��248��$��75��
���������Z� ���� $ button2.png���� $ 
Horizontal=�$��51��$��0,0,0,0q�.+��� -   $ button_server��$��Call Server��$��Khmer UI)�$	��124��$��50��
�������$��0,0,0,1q���Z� ���� $ button2.png���� -   $ button_help��$��?��$	��124��$��Khmer UI)�$��50��
�������$��0,0,0,1q���Z� ���� $ button2.png��