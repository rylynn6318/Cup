// Copyright 2025 rylynn6318. All rights reserved.

#pragma once

#include "CoreMinimal.h"
#include "CommonButtonBase.h"
#include "CupButtonBase.generated.h"

/**
 *
 */
UCLASS()
class CUP_API UCupButtonBase : public UCommonButtonBase
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable)
	void SetButtonText(const FText& InText);

protected:
	virtual void NativePreConstruct() override;

	virtual void UpdateInputActionWidget() override;
	virtual void OnInputMethodChanged(ECommonInputType CurrentInputType) override;

	void RefreshButtonText();

	UFUNCTION(BlueprintImplementableEvent)
	void UpdateButtonText(const FText& InText);

	UFUNCTION(BlueprintImplementableEvent)
	void UpdateButtonStyle();

private:
	UPROPERTY(EditAnywhere, Category = "Button", meta = (InlineEditConditionToggle))
	bool bOverride_ButtonText;

	UPROPERTY(EditAnywhere, Category = "Button", meta = (editcondition = "bOverride_ButtonText"))
	FText ButtonText;
};
