   M S B A M L   `   `   `  ����U  QPathFinderCharacterCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:PathFinderCharacterCreator.Windows"PathFinderCharacterCreator.Windows  5   	   9    3PathFinderCharacterCreator.Windows.addNewBackground   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:PathFinderCharacterCreator.Windows     5   	     � Title$  addNewBackground��5   	   $��572.841��6"   $��606.964��63   .��5	      � $	��543��6   $	��Top=�6   $��0,0,0,-1q�60   .+�5
   
   �� -   5         ��Name$ lstAvailableFeats��5
      $
��Left=�6-   $	��205��6H   $��6,36,0,0q�6U   $	��Top=�6g   $	��140��6   ��5      �� 5      .R�5      � $	��0,2q�6    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $	��100 �6/   .+�5      �� ��6$   �� *Name+5      5      5      �� 5   
   -   5        $ lstSelectedFeats��5      $
��Left=�6,   $	��205��6G   $��
222,36,0,0q�6T   $	��Top=�6h   $	��140��6�   ��5      �� 5      .R�5      � $	��0,2q�6    5      �� 5      $��* �6/   �� 5      $	��100 �6/   .+�5      �� ��6$   �� *Name+5!      5"      5$      �� 5%   
   $��Available Feats:��6   $
��Left=�6+   $��6,5,0,0q�6F   $	��Top=�6W   �� 5&   
   $��BackGround Feats:��6   $
��Left=�6,   $��	222,5,0,0q�6G   $	��Top=�6Z   �� 5'   
   -   5         ��Name$ ButtonAddFeat��5'      $��>��6(   $
��Left=�67   $��
151,98,0,0q�6R   $	��Top=�6f   $��66��6~   6�   �� 5(   
   -   5        $ ButtonRemoveFeat��5(      $��<��6+   $
��Left=�6:   $��151,138,0,0q�6U   $	��Top=�6j   $��66��6�   6�   � 5)   
   -   5         �Name$ 
SkillsGrid��5)      
�������$
��Left=�6:    � ShowGridLines .  $	��484��6k   $��405,10,0,-75q�6x   $	��Top=�6�   $	��171��6�   �� 5*   
   $��Name:��6   $
��Left=�6    $��	6,252,0,0q�6;   $	��Top=�6N   �� 5+   
   -   5         ��Name$ txtName��5+      $
��Left=�6#   $��23��6>   $��
55,256,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5,   
   $��Description:��6   $
��Left=�6'   $��	6,283,0,0q�6B   $	��Top=�6U   �� 5-   
   -   5         ��Name$ txtDescription��5-      $
��Left=�6.   $	��116��6I   $��	6,314,0,0q�6V   $	��Top=�6i   $	��205��6�   . �5.      /� .T�5/      J� .*�6   .*�50      �� $� ��6   51      52      53      �� 54   
   -   5        $��txt_free��54      $
��Left=�6#   $��23��6>   $��299,407,0,0q�6J   $
 Wrap=�6_   $��0��6s   $	��Top=�6|   $��15��6�   �� 55   
   $
��Free��6   $
��Left=�6   $��256,403,0,0q�6:   $	��Top=�6O   	 J� RenderTransformOrigin$	 0.943,6.917&�6g   $��38��6�   �� 56   
   -	   5        
 ��Name$
 CheckBoxStrengthBoost��56      $��Strength��62   $
��Left=�6E   $��256,283,0,0q�6`   $	��Top=�6u   �� 57   
   -
   5        $
 CheckBoxDexterityBoost��57      $��	Dexterity��63   $
��Left=�6G   $��256,303,0,0q�6b   $	��Top=�6w   �� 58   
   -   5        $
 CheckBoxConstitutionBoost��58      $��Constitution��66   $
��Left=�6M   $��256,323,0,0q�6h   $	��Top=�6}   �� 59   
   -   5        $
 CheckBoxIntelligenceBoost��59      $��Intelligence��66   $
��Left=�6M   $��256,343,0,0q�6h   $	��Top=�6}   �� 5:   
   -   5        $
 CheckBoxWisdomBoost��5:      $��Wisdom��60   $
��Left=�6A   $��256,363,0,0q�6\   $	��Top=�6q   �� 5;   
   -   5        $
 CheckBoxCharismaBoost��5;      $��Charisma��62   $
��Left=�6E   $��256,383,0,0q�6`   $	��Top=�6u   �� 5<   
   $��Boost��6   $
��Left=�6    $��276,252,0,0q�6;   $	��Top=�6P   �� 5=   
   -   5        $��btn_add_background��5=      $��Add Background��6+   $
��Left=�6D   $��
10,435,0,0q�6_   $	��Top=�6s   $	��110��6�   5?      5@      