   M S B A M L   `   `   `  ����  GramDominator#    facedominator.LicensingWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      -   5        7  1FirstFloor.ModernUI.Windows.Controls.ModernWindow   Name$  LicenseCheckWindow��5      $	��600��5   $   $	��600��64    � Title$! GramDominator 2.0 Licensing��5         IsTitleVisible .    BlankWindow#��[  5
      $��423.404��68   $��578.723��6I    � 
ResizeMode$ CanMinimize=�6Y    � WindowStartupLocation$ CenterScreen=�6r   .��5      � .+�5   
   �� -   5        $��btnValidate��5   !   $��Start��6   
��� � �$��80��6G   $��30��6R   $��242,299,242,22q�6x   =  7FirstFloor.ModernUI.Windows.Controls.ModernProgressRing  5   
   -   5        $��licenseCheckProgressbar��5   !      IsActive .  $	��161��6Q   $	��108��6]      ThreeBounceProgressRingStyle#��[ 6j   $��216,356,217,108q�6�   �� 5   
   ���	#FF070808$�� ��6+   $
��Left=�65   $��	62,10,0,0q�6P   $	��Top=�6c   $	��485��6{   $	��231��6�   .��5      � $��-8,-13,-12,-313q�6   $��Right=�6-   $	��493��6I   .+�5      �� -   5        $��lblCPUId��5   *   $��CPU-ID ��6   $
��Left=�6:   $��
135,12,0,0q�6U   $	��Top=�6i   �� 5      $��Username : ��6   $
��Left=�6.   $��	84,42,0,0q�6I   $	��Top=�6\   $��Italic$�6t   �� 5      $��Password : ��6   $
��Left=�6.   $��	87,73,0,0q�6I   $	��Top=�6\   $��Italic$�6t   �� 5      $��Transaction ID : ��6   $
��Left=�64   $��
61,101,0,0q�6O   $	��Top=�6c   $��Italic$�6{   �� 5      $��
Email  :  ��6   $
��Left=�6-   $��105,134,0,0q�6H   $	��Top=�6]   $��Italic$�6u   �� 5      $��License Status  : ��6   $
��Left=�65   $��
61,162,0,0q�6P   $	��Top=�6d   $��93��6|   $��Italic$�6�   �� 5      -   5        $��txtUserName��5   3   ���	#FF070808$
��Left=�6F   $��23��6a   $��
179,40,0,0q�6m    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��177��6�   G� 5      -   5        $��txtPassword��5   7   ���	#FF070808$
��Left=�6J   $��23��6e   $��
180,69,0,0q�6q   $	��Top=�6�   $	��176��6�   �� 5      -   5        $��txtTransactionID��5   3   ���	#FF070808$
��Left=�6K   $��23��6f   $��
181,98,0,0q�6r   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��175��6�   �� 5      -   5        $��txtEmail��5   3   ���	#FF070808$
��Left=�6C   $��23��6^   $��181,131,0,0q�6j   $
 Wrap=�6   $�� ��6�   $	��Top=�6�   $	��175��6�   �� 5      -	   5        $��LblActiveStatus��5   -   
��� � �
���  ��$��
Not Active��6V   $
��Left=�6k   $��184,164,0,0q�6�   $	��Top=�6�   $	��170��6�   $��18��6�   �� 5      -
   5        $��LblActivetedStatus��5   -   
��� � �
��� � �$��Licence Activated��6[   $
��Left=�6w   $��184,164,0,0q�6�   $	��Top=�6�   $	��170��6�   $��18��6�   $y�Hidden=�6�   �� 5      -   5        $��
LblMessage��5      $��Center=�6.   $9��3Please Click on the button to Validate your license��6K   $��10,228,10,273q�6�   $	��473��6�   5      5      �� 5    
   -   5        $��btnActivate��5    &   
��� � �$��Activate��6:   $
��Left=�6M   $��257,363,0,0q�6h   $	��Top=�6}   $��99��6�   $��43��6�   6�   5%      5&      