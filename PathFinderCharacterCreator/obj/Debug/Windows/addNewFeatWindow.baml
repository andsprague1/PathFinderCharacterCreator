   M S B A M L   `   `   `  ����U  QPathFinderCharacterCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:PathFinderCharacterCreator.Windows"PathFinderCharacterCreator.Windows  5   	   9    3PathFinderCharacterCreator.Windows.addNewFeatWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:PathFinderCharacterCreator.Windows     5   	     � Title$  addNewFeatWindow��5   	   $��303.343��6"   $��475.348��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5        $��FeatTypeComboBox��5      $
��Left=�6+   $��	10,41,0,0q�6F   $	��Top=�6Y   $	��141��6q   .@�5      �� $��
Class Feat��6   �� 5      $��Heritage Feat��6   �� 5      $��Ancestry Feat��6   �� 5      $��General Feat��6   �� 5      $��
Skill Feat��6   5      �� 5   
   -   5        $��listBoxFeats��5      $
��Left=�6&   $	��253��6A   $��
277,10,0,0q�6N   $	��Top=�6b   $	��176��6z   ��5   
   �� 5      .R�5      � $	��0,2q�6    5      �� 5      $��* �6+   �� 5      $	��100 �6+   .+�5      �� ��6    �� *Name+5      5      5       �� 5!   
   -   5        $��FeatNameTextBox��5!      $
��Left=�6)   $��23��6D   $��	10,94,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��235��6�   �� 5"   
   $��Feat Type                ��6   $
��Left=�5#      $��	10,10,0,0q�6-   $	��Top=�6@    J� RenderTransformOrigin$ 0.456,0.505&�6X   �� 5$   
   -   5        $��TextBoxDescription��5$      $
��Left=�60   $��85��6K   $��
10,153,0,0q�6W   $	��Top=�6k   $	��235��6�   . �5%      /� .T�5&      J� .*�6   .*�5'      �� $� ��6   5(      5)      5*      �� 5+   
   $��
Feat Name:��6   $
��Left=�6%   $��	10,68,0,0q�6@   $	��Top=�6S   �� 5,   
   $��
Feat Text:��6   $
��Left=�6%   $��
10,122,0,0q�6@   $	��Top=�6T   �� 5-   
   -   5        $��	AddButton��5-   #   $��Add New��6   $
��Left=�64   $��
10,243,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5.   
   -   5        $��
SaveButton��5.       $
��Save��6   $
��Left=�62   $��
90,243,0,0q�6M   $	��Top=�6a   $��75��6y   6�   �� 5/   
   -   5        $��DeleteButton��5/   "   $��Delete��6   $
��Left=�66   $��170,243,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 50   
   -   5        $��txtLevel��50      $
��Left=�6"   $��23��6=   $��
170,40,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $��34��6�   52      53      