# CDW Development Template v2024.01.28

A template repository for fast starts with .NET, Bicep, Developer CLI and Azure.

```bash

TENANT_ID=<<YOUR_TENANT_ID>>
SUBSCRIPTION_ID=<<YOUR_SUBSCRIPTION_ID>>
ENVIRONMENT_NAME=<<YOUR_ENVIRONMENT_NAME>>
LOCATION=<<YOUR_AZURE_REGION>>

azd auth login --tenant-id $TENANT_ID

azd env new $ENVIRONMENT_NAME --subscription $SUBSCRIPTION_ID --location $LOCATION

azd provision

azd deploy

```