   M S B A M L   `   `   `  ����U  QPathFinderCharacterCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:PathFinderCharacterCreator.Windows"PathFinderCharacterCreator.Windows  5   	   =    7PathFinderCharacterCreator.Windows.addNewAncestryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:PathFinderCharacterCreator.Windows     5   	     � Title$  addNewAncestryWindow��5   	   $��366.017��6&   $��594.429��67   .��5	      � .+�5
   
   �� $
��Left=�6   $��23��6-   $��
53,184,0,0q�69    �� TextWrapping$
 Wrap=�6M   $��0��6a   $	��Top=�6j   $��15��6�   �� 5   
   $
��Free��6   $
��Left=�6   $��
10,180,0,0q�6:   $	��Top=�6N    J� RenderTransformOrigin$ 0.943,6.917&�6f   $��38��6�   �� 5   
   -   5        $��CheckBoxStrengthBoost��5      $��Strength��60   $
��Left=�6C   $��	10,60,0,0q�6^   $	��Top=�6q   �� 5   
   -   5         ��Name$ CheckBoxDexterityBoost��5      $��	Dexterity��63   $
��Left=�6G   $��	10,80,0,0q�6b   $	��Top=�6u   �� 5   
   -   5        $ CheckBoxConstitutionBoost��5      $��Constitution��66   $
��Left=�6M   $��
10,100,0,0q�6h   $	��Top=�6|   �� 5   
   -   5        $ CheckBoxIntelligenceBoost��5      $��Intelligence��66   $
��Left=�6M   $��
10,120,0,0q�6h   $	��Top=�6|   �� 5   
   -   5        $ CheckBoxWisdomBoost��5      $��Wisdom��60   $
��Left=�6A   $��
10,140,0,0q�6\   $	��Top=�6p   �� 5   
   -   5        $ CheckBoxCharismaBoost��5      $��Charisma��62   $
��Left=�6E   $��
10,160,0,0q�6`   $	��Top=�6t   �� 5   
   -   5        $ CheckBoxStrengthFlaw��5      $��Strength��61   $
��Left=�6D   $��
110,60,0,0q�6_   $	��Top=�6s   �� 5   
   -   5        $ CheckBoxDexterityFlaw��5      $��	Dexterity��62   $
��Left=�6F   $��
110,80,0,0q�6a   $	��Top=�6u   �� 5   
   -	   5        $ CheckBoxConstitutionFlaw��5      $��Constitution��65   $
��Left=�6L   $��110,100,0,0q�6g   $	��Top=�6|   �� 5   
   -
   5        $ CheckBoxIntelligenceFlaw��5      $��Intelligence��65   $
��Left=�6L   $��110,120,0,0q�6g   $	��Top=�6|   �� 5   
   -   5        $ CheckBoxWisdomFlaw��5      $��Wisdom��6/   $
��Left=�6@   $��110,140,0,0q�6[   $	��Top=�6p   �� 5   
   -   5        $ CheckBoxCharismaFlaw��5      $��Charisma��61   $
��Left=�6D   $��110,160,0,0q�6_   $	��Top=�6t   �� 5   
   $��Speed:��6   $
��Left=�6!   $��
10,218,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $��TextBoxSpeed��5      $
��Left=�6&   $��23��6A   $��
61,222,0,0q�6M   $
 Wrap=�6a   $��30��6u   $	��Top=�6   $��30��6�   �� 5   
   $��Hit Points:��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   �� 5   
   -   5        $��TextBoxHitPoints��5      $
��Left=�6+   $��23��6F   $��	79,13,0,0q�6R   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   $��Size: ��6   $
��Left=�6!   $��
10,249,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $��ComboBoxSize��5      $
��Left=�6(   $��
61,253,0,0q�6C   $	��Top=�6W   $	��120��6o    �� SelectedIndex$ 2��6{   .@�5      �� $
��Tiny��6   �� 5      $��Small��6   �� 5       $��Medium��6   �� 5!      $��Large��6   5"      �� 5#   
   -   5        $��lstAvailableFeats��5#      $
��Left=�6+   $	��205��6F   $��
216,70,0,0q�6S   $	��Top=�6g   $	��140��6   ��5$      �� 5%      .R�5&      � $	��0,2q�6    � ColumnDefinitions 5'      �� 5(      $��* �6/   �� 5)      $	��100 �6/   .+�5+      �� ��6$   �� *Name+5,      5-      5/      �� 50   
   -   5        $��lstSelectedFeats��50      $
��Left=�6*   $	��205��6E   $��
432,70,0,0q�6R   $	��Top=�6f   $	��140��6~   ��51      �� 52      .R�53      � $	��0,2q�6    54      �� 55      $��* �6/   �� 56      $	��100 �6/   .+�58      �� ��6$   �� *Name+59      5:      5<      �� 5=   
   $��Available Feats:��6   $
��Left=�6+   $��
216,39,0,0q�6F   $	��Top=�6Z   �� 5>   
   $��Class Feats:��6   $
��Left=�6'   $��
432,39,0,0q�6B   $	��Top=�6V   �� 5?   
   -   5        $��ButtonAddFeat��5?      $��>��6&   $
��Left=�62   $��361,132,0,0q�6M   $	��Top=�6b   $��66��6z   6�   �� 5@   
   -   5        $��ButtonRemoveFeat��5@      $��<��6)   $
��Left=�68   $��361,172,0,0q�6S   $	��Top=�6h   $��66��6�   6�   �� 5A   
   -   5         ��Name$ 
SaveButton��5A       $
��Save��6   $
��Left=�64   $��
10,293,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5B   
   -   5        $��checkBoxDarkVision��5B      $��Dark Vision��6-   $
��Left=�6C   $��110,224,0,0q�6^   $	��Top=�6s   �� 5C   
   $��Boost��6   $
��Left=�6    $��	30,29,0,0q�6;   $	��Top=�6N   �� 5D   
   $
��Flaw��6   $
��Left=�6   $��
131,29,0,0q�6:   $	��Top=�6N   5F      5G      