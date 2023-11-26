param([string] $help,  [string] $pod, $addends)
write-host $help
write-host $pod
foreach ($addend in $addends)
{
    $givenname = $addend.substring(0,1).toupper()+$addend.substring(1)
    write-host $givenname
}



#
# Author: Greg D. Moore
# Date: 2020-02-18
# Version: 1.0
# Show boolean help
#