---
external help file: Microsoft.Azure.PowerShell.Cmdlets.ManagementPartner.dll-Help.xml
Module Name: Az.ManagementPartner
online version: https://learn.microsoft.com/powershell/module/az.managementpartner/new-azmanagementpartner
schema: 2.0.0
---

# New-AzManagementPartner

## SYNOPSIS
Associates a Microsoft Partner Network(MPN) ID to the current authenticated user or service principal.

## SYNTAX

```
New-AzManagementPartner [-PartnerId] <String> [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Associates a Microsoft Partner Network(MPN) ID to the current authenticated user or service principal.

## EXAMPLES

### Example 1
```powershell
New-AzManagementPartner -PartnerId 4977985
```

```output
PartnerId   : 4977985
PartnerName : Test_Test_DPORTest
TenantId    : 00001111-aaaa-2222-bbbb-3333cccc4444
ObjectId    : aa67f786-0552-423e-8849-244ed12bf581
State       : Active
```

Add a management partner

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerId
The management partner id, it is a 6 digits number

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Commands.ManagementPartner.PSManagementPartner

## NOTES

## RELATED LINKS

[Remove-AzManagementPartner](./Remove-AzManagementPartner.md)

[Get-AzManagementPartner](./Get-AzManagementPartner.md)

[Update-AzManagementPartner](./Update-AzManagementPartner.md)
