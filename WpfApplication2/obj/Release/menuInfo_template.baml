   M S B A M L   `   `   `  ����   WpfApplication2'    !WpfApplication2.menuInfo_template   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � 	Resources   �� 
TargetType �� Property �� Value �� 
TargetType �Name ��Name �� Padding �� Triggers	 P� Property
 P� Value �� 
TargetName �� ImageSource��%  '��       �� " ��.���  � �� �� " ��.R�� $
 Grid��.+��� $ Border��#��z��#��z��#��z��# z���� #��z��#��z��#��z����.  P� 	 � ��
 . . ��� $ Border�� � �� �� $ button1.png���� $ Border�� � �� �� $ button2.png��.���� .+��� $��1q�$	��681��
 �� Top$ 39��$
��1050�����#292421�� -    ��Name$ 	DishImage��$��
Nachos.jpg�� �� Left$ 19��$	 122��$	��285��$	��398��$
��Fill=��� -   $��DishName��$��Nacho and Cheese��$ 69��$��51��$
��1030��$��Bottom=�$ 10��$��36(�
�������$��Khmer UI)��� $��Description:��$ 15��$	 412��$��44��$	��141��$��24(�
��������� -   $��DishDescription��$ 22��$	 456��$	��122��$	��398��$����Tri-coloured tortilla chips, tomatoes, black olives, jalapeños, green onions, and mixed cheese. Served with salsa and sour cream.��
�������$��20(�$
��Wrap=�$��Khmer UI)��� -   $��	nutrition��$	��336��$	��270��$	 765��$	 179��
���������Z� .@��� $��Nutrition Facts: ��$��34(�$
��Bold"�$��Khmer UI)�$	��260���� $��Calories 200��$��16(�$��20, 0q�$��Khmer UI)��� $��Total Fat 1g��$��16(�$��20, 0q�$��Khmer UI)��� $��Choleserol 0mg��$��16(�$��20, 0q�$��Khmer UI)��� $��
Sodium 7mg��$��16(�$��20, 0q�$��Khmer UI)��� $��Total Carbohydrate 36g��$��16(�$��20, 0q�$��Khmer UI)��� $��Protein 13g��$��16(�$��20, 0q�$��Khmer UI)��� $��Add/Remove Ingredients��$	 434��$	 140��$��39��$	��313��$��24(�
�������$��Khmer UI)��� -   $��list_of_ingredients��$	��336��$	��313��$	 434��$	 179��
�������
���   ���Z� ���� .R��� $��Khmer UI)����	#FFB0B0B0���	#FF5B5B5B
���   ����� *button_name+ d� 	IsChecked �� *
is_checked+ � LayoutTransform ��  �� ScaleX$ 2Q� �� ScaleY$ 2Q��� -   $��
Add_Button��$	��ADD��$��4��$��1��$��Khmer UI)�$��18(�
�������$��2��$	 797��$	 589��$	��233��$��63����Z� ���� $ button2.png���� $��Allergy Alert!��$��44��$	 401��$	 554��$	��384��$��30(����	#FFE00000$y�Visible=�$��Khmer UI)�$
��Bold"��� -    ��Name$ decrease_quantity_button��$��-��$��48(�$��61��$	 797��$	 530��$��79��$��Gulim)�
���������Z� ���� $ button2.png���� -   $ increase_quantity_button��$��+��$��48(�$��61��$	 956��$	 530��$��74��$��Gulim)�
���������Z� ���� $ button2.png���� -	    ��Name$ quantity_text��$��58��$	 876��$
��Wrap=�$��1��$��40(� �� TextAlignment$ Center=�$	 531��$��80��
��������� -
   $��list_of_allergy��$��Dairy | Gluten ��$��24(�$	 401��$	 598��
���  ��$��Khmer UI)�$��Italic$�$	��384��$��54���� -   $ item_info_back_button��$
��Back��$��18(�$��75��$ 19��$	 583��$��94��$��Khmer UI)�
���������Z� ���� $ button2.png���� 
���   �$��12��$	 776��
���   �$	 221��$	��244���� 
���   �$��5��$	 776��
���   �$	 262��$	��244���� 
���   �$��5��$	 776��
���   �$	 294��$	��244���� 
���   �$��5��$	 776��
���   �$	 327��$	��244���� 
���   �$��5��$	 776��
���   �$	 358��$	��244���� 
���   �$��5��$	 776��
���   �$	 391��$	��244���� -   $��infoScreen_price��$��Right=�$�� ��$	 264��$	 407��$��49��$	��141��$��24(�
�������$��Khmer UI)�$��Italic$� J� RenderTransformOrigin$ -0.116,0.575&�