   M S B A M L   `   `   `  ����H  DGramDominator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GramDominator.ClassesGramDominator.Classes  5      G    AGramDominator.CustomUserControls.UserControlUnlikePhotoByUsername   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      -app#clr-namespace:GramDominator.Classes  5      .��5
      �� .��5   
   �   � DataContext  5      &    GramDominator.Classes.Validation  5      -   5        objform��5   !    � ColumnDefinitions 5      �� 5      $	��97* �6#   �� 5      $	��23* �6#    � RowDefinitions 5      �� 5      $	��24* �6    �� 5      $
��109* �6    �� 5      $	��34* �6    �� 5      $	��83* �6    .+�5      �� $��0��6   $��Photo UnLike By Username��6%   $��Center=�6E   $
��Bold"�6b   $��18(�6t   $��2��6�   �� 5      $��Input��6   $��1��6&   $��2��63   .��5      �  5      �� 5      $
��135* �6+   �� 5      $	��25* �6+   �� 5      $
��119* �6+   �� 5       $
��171* �6+   �� 5!      $
��138* �6+    5#      �� 5$      $	��41* �6(   �� 5%      $	��46* �6(   .+�5'      	� -   5        $*��$rdoBtn_UnLikeBy_PhotoUser_SingleUser��5'   "    d� 	IsChecked$
 TrueY�6N   $��Single User��6_   $��0��6u   $��2��6�   $��25��6�    	� 	GroupName$ ScrapeByKeyWord��6�   $��Right=�6�   $	��0,2q�6  $	��109��6  	� 5(      -   5        $,��&rdoBtn_UnLikeBy_PhotoUser_MultipleUser��5(   "   $��Multiple Users��6P   $��0��6i   $��3��6v   $��25��6�   $ ScrapeByKeyWord��6�   $��Right=�6�   $	��0,2q�6  $	��171��6  �� 5)      -   5        $��UnLikeby_Username��5)      $��	User Name��65   $��1��6I   $��0��6V   $��25��6f   $��Right=�6r   $��Center=�6�   $
��0,11q�6�   $��2��6�   $	��111��6�   �� 5*      -   5        $,��&txt_UnLikePhoto_Username_LoadUsersPath��5*       �� 
IsReadOnly .  $�� ��6_   $��1��6g   $��2��6t   $��25��6�   $��
10,11,0,11q�6�   $��Center=�6�   $��2��6�   $��1,1,1,2q�6�   �� 5+      -   5        $*��$btn_UnLikePhoto_Username_BrowseUsers��5+      $y�Hidden=�6I   $��Browse��6]   $��1��6n   $��4��6{   $��25��6�   $��10,11q�6�   
��� � ���5,      �� 5-       �� 
TargetType" ��6.   .R�5.   "   ��  �� CornerRadius$ 5��6)   
���W�.�$��1,1,1,2q�6Q   
�������._�5/   &   �� $��Center=�67   $��Center=�6T   50   #   51      53      54      55      �� 56      $��No. of Photo��6   $��5,10,360,14q�6+   $��26��6@   $��Center=�6L   $��2��6g   �� 57      -   5        $)��#txtMessage_UnLike_NoOfphotousername��57      $��130,12.06,250,15.94q�6A    �� TextAlignment$ Center=�6^   	 �� TextWrapping$
	 Wrap=�6u   $��5��6�   $��26��6�   $��Center=�6�   $��2��6�   $��1,1,1,2q�6�   �� 58      -   5        
 ��Name$$
 btn_UnLikePhoto_Username_Clear��58      
����  �$��Clear��6P   $��2��6`   $��25��6m   $��
0,12,10,18q�6�   $��1��6�   ��59      �� 5:      " ��6&   .R�5;      �� $ 5��6!   
����  �$��1,1,1,2q�6E   
�������._�5<      �� $��Center=�6/   $��Center=�6L   5=      5>      5@      5A      5B      5C      