   M S B A M L   `   `   `  ����A  =Report, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Report.PagesReport.Pages  5          Report.Pages.November   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Report.Pages     5        N� Title$  Novober��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5      $��0,76,96,267q�6   $��Bahnschrift)�64   $��11(�6M      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия Имя��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Name+  5      $ 01.11��6%    64   �� *Nov1+  5      $ 02.11��6%    64   �� *Nov2+  5      $ 03.11��6%    64   �� *Nov3+  5      $ 04.11��6%    64   �� *Nov4+  5      $ 05.11��6%    64   �� *Nov5+  5      $ 06.11��6%    64   �� *Nov6+  5      $ 07.11��6%    64   �� *Nov7+  5      $ 08.11��6%    64   �� *Nov8+  5      $ 10.11��6%    64   �� *Nov9+  5      $ 11.11��6%    64   �� *Nov11+  5      $ 11.11��6%    64   �� *Nov11+  5      $ 12.11��6%    64   �� *Nov12+  5      $ 13.11��6%    64   �� *Nov13+  5      $ 14.11��6%    64   �� *Nov14+  5      $ 15.11��6%    64   �� *Nov15+  5      $ 16.11��6%    64   �� *Nov16+  5       $ 17.11��6%    64   �� *Nov17+  5!      $ 18.11��6%    64   �� *Nov18+  5"      $ 19.11��6%    64   �� *Nov19+  5#      $ 20.11��6%    64   �� *Nov20+  5%      $ 21.11��6%    64   �� *Nov21+  5&      $ 22.11��6%    64   �� *Nov22+  5'      $ 23.11��6%    64   �� *Nov23+  5(      $ 24.11��6%    64   �� *Nov24+  5)      $ 25.11��6%    64   �� *Nov25+  5*      $ 26.11��6%    64   �� *Nov26+  5+      $ 27.11��6%    64   �� *Nov27+  5,      $ 28.11��6%    64   �� *Nov28+  5-      $ 29.11��6%    64   �� *Nov29+  5.      $ 30.11��6%    64   �� *Nov30+52      �� 53   
   $
��Left=�6   $��	10,42,0,0q�6/   $
��Wrap=�6B   $��Ноябрь��6V   $	��Top=�6d   $��Bahnschrift)�6|   $��24(�6�   $
��Bold"�6�   
�������6�   �� 54   
   -   5         ��Name$ btSave��54      $��Сохранить��6!   $��
141,10,0,0q�65   $��22(�6I   $��Bahnschrift)�6W    �� IsCancel . 
�������$
��Left=�6�   $	��211��6�   $��85��6�   $	��Top=�6�   ��55      �� 56       �� 
TargetType" ��6   .�57      �� 	 �� Property	 � ��
 �� Value
 �#462AD863    �� Triggers 58      P� 59       P� Property �@J�IsMouseOver P� Value . . �5:      �� 	 � ��
 �#28AEED6;   5;      5=      ��5?      �� 5@       �� 
TargetType" ��6"   .R�5A      �� $	��200��6   $��30��6)    �� CornerRadius$ 20��5B      #��z��5C      ._�5D      �� $��Center=�6+   $��Center=�5E   !   5F      5G      5I      � 5J   
    J� Opacity$ 0Q�6   $��
-10,0,10,0q�6   .+�5K      �� -   5         ��Name$ tbName��5K      $
��Left=�6&   $��19��6A   $��
436,43,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6�   $��26��6�   ��6u   �� *SelectedItem.Name+ �� ElementName$ dg��6�   �� 5L      -   5        $
 tb01��5L      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov1+$ dg��6�   �� 5M      -   5        $
 tb02��5M      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov2+$ dg��6�   �� 5N      -   5        $
 tb03��5N      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov3+$ dg��6�   �� 5O      -   5        $
 tb04��5O      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov4+$ dg��6�   �� 5P      -   5        $
 tb05��5P      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov5+$ dg��6�   �� 5Q      -	   5        $
 tb06��5Q      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov6+$ dg��6�   �� 5R      -
   5        $
 tb07��5R      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov7+$ dg��6�   �� 5S      -   5        $
 tb08��5S      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov8+$ dg��6�   �� 5T      -   5        $
 tb09��5T      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov9+$ dg��6�   �� 5U      -   5        $
 tb10��5U      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov10+$ dg��6�   �� 5V      -   5        $
 tb11��5V      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov11+$ dg��6�   �� 5W      -   5        $
 tb12��5W      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov12+$ dg��6�   �� 5X      -   5        $
 tb13��5X      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov13+$ dg��6�   �� 5Y      -   5        $
 tb14��5Y      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov14+$ dg��6�   �� 5Z      -   5        $
 tb15��5Z      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov15+$ dg��6�   �� 5[      -   5        $
 tb16��5[      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov16+$ dg��6�   �� 5\      -   5        $
 tb17��5\      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov17+$ dg��6�   �� 5]      -   5        $
 tb18��5]      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov18+$ dg��6�   �� 5^      -   5        $
 tb19��5^      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov19+$ dg��6�   �� 5_      -   5        $
 tb20��5_      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov20+$ dg��6�   �� 5`      -   5        $
 tb21��5`      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov21+$ dg��6�   �� 5a      -   5        $
 tb22��5a      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov22+$ dg��6�   �� 5b      -   5        $
 tb23��5b      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov23+$ dg��6�   �� 5c      -   5        $
 tb24��5c      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov24+$ dg��6�   �� 5d      -   5        $
 tb25��5d      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov25+$ dg��6�   �� 5e      -   5        $
 tb26��5e      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov26+$ dg��6�   �� 5f      -   5        $
 tb27��5f      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov27+$ dg��6�   �� 5g      -   5        $
 tb28��5g      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov28+$ dg��6�   �� 5h      -    5        $
 tb29��5h      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov29+$ dg��6�   �� 5i      -!   5        $
 tb30��5i      $
��Left=�6$   $��19��6?   $��
436,43,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $��26��6�   ��6s   �� *SelectedItem.Nov30+$ dg��6�   5j      5l      5m      