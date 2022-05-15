using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

namespace AF.UI
{
public class UIMainScreenScreenComponents : MonoBehaviour
{
	public Image UILeftBarMenuImage{ get; protected set; }
	public Button UILeftBarMenuImageMenuButton{ get; protected set; }
	public RectTransform UILeftBarMenuImageHolder{ get; protected set; }
	public Button UILeftBarMenuImageHolderMovementButton{ get; protected set; }
	public TextMeshProUGUI UILeftBarMenuImageHolderMovementButtonText{ get; protected set; }
	public Button UILeftBarMenuImageHolderCreateWallButton{ get; protected set; }
	public TextMeshProUGUI UILeftBarMenuImageHolderCreateWallButtonText{ get; protected set; }
	public Button UILeftBarMenuImageHolderEditWallButton{ get; protected set; }
	public TextMeshProUGUI UILeftBarMenuImageHolderEditWallButtonText{ get; protected set; }
	public Button UILeftBarMenuImageHolderPartialWallButton{ get; protected set; }
	public TextMeshProUGUI UILeftBarMenuImageHolderPartialWallButtonText{ get; protected set; }
	public Button UILeftBarMenuImageHolderEntireWallButton{ get; protected set; }
	public TextMeshProUGUI UILeftBarMenuImageHolderEntireWallButtonText{ get; protected set; }
	public Image UILeftBarMenuImageHeightJoystick{ get; protected set; }
	public Image UILeftBarMenuImageHeightJoystickButton{ get; protected set; }
	public TextMeshProUGUI UILeftBarMenuImageHeightJoystickButtonText{ get; protected set; }
	public ScrollRect UICostumizeWallType{ get; protected set; }
	public Button UICostumizeWallTypeSetWallColor{ get; protected set; }
	public TextMeshProUGUI UICostumizeWallTypeSetWallColorText{ get; protected set; }
	public Button UICostumizeWallTypeSetWallType{ get; protected set; }
	public TextMeshProUGUI UICostumizeWallTypeSetWallTypeText{ get; protected set; }
	public Image UICostumizeWallTypeViewport{ get; protected set; }
	public RectTransform UICostumizeWallTypeViewportContent{ get; protected set; }
	public Scrollbar UICostumizeWallTypeScrollbarHorizontal{ get; protected set; }
	public Image UICostumizeWallColor{ get; protected set; }
	public Button UICostumizeWallColorSetRGBColor{ get; protected set; }
	public TextMeshProUGUI UICostumizeWallColorSetRGBColorText{ get; protected set; }
	public Button UICostumizeWallColorSetWallColor{ get; protected set; }
	public TextMeshProUGUI UICostumizeWallColorSetWallColorColorText{ get; protected set; }
	public Button UICostumizeWallColorSetWallType{ get; protected set; }
	public TextMeshProUGUI UICostumizeWallColorSetWallTypeTypeText{ get; protected set; }
	public Image UICostumizeWallColorColor0{ get; protected set; }
	public Button UICostumizeWallColorColor1{ get; protected set; }
	public Button UICostumizeWallColorColor2{ get; protected set; }
	public Button UICostumizeWallColorColor3{ get; protected set; }
	public Button UICostumizeWallColorColor4{ get; protected set; }
	public Button UICostumizeWallColorColor5{ get; protected set; }
	public Button UICostumizeWallColorColor6{ get; protected set; }
	public Button UICostumizeWallColorColor7{ get; protected set; }
	public Button UICostumizeWallColorColor8{ get; protected set; }
	public Button UICostumizeWallColorColor9{ get; protected set; }
	public Button UICostumizeWallColorColor10{ get; protected set; }
	public Button UICostumizeWallColorColor11{ get; protected set; }
	public Button UICostumizeWallColorColor12{ get; protected set; }
	public Button UICostumizeWallColorColor13{ get; protected set; }
	public Button UICostumizeWallColorColor14{ get; protected set; }
	public Button UICostumizeWallColorColor15{ get; protected set; }
	public Button UICostumizeWallColorColor16{ get; protected set; }
	public Button UICostumizeWallColorColor17{ get; protected set; }
	public Button UICostumizeWallColorColor18{ get; protected set; }
	public Button UICostumizeWallColorColor19{ get; protected set; }
	public InputSliderComponent UICostumizeWallColorRInputSlider{ get; protected set; }
	public InputSliderComponent UICostumizeWallColorGInputSlider{ get; protected set; }
	public InputSliderComponent UICostumizeWallColorBInputSlider{ get; protected set; }
	public RectTransform UIMovementButtons{ get; protected set; }
	public Button UIMovementButtonsTopViewButton{ get; protected set; }
	public TextMeshProUGUI UIMovementButtonsTopViewButtonText{ get; protected set; }
	public Button UIMovementButtonsFreeRoamButton{ get; protected set; }
	public TextMeshProUGUI UIMovementButtonsFreeRoamButtonText{ get; protected set; }
	public Button UIMovementButtonsARButton{ get; protected set; }
	public TextMeshProUGUI UIMovementButtonsARButtonText{ get; protected set; }
	public RectTransform UIJoysticks{ get; protected set; }
	public Image UIJoysticksMoveJoystick{ get; protected set; }
	public Image UIJoysticksMoveJoystickButton{ get; protected set; }
	public TextMeshProUGUI UIJoysticksMoveJoystickButtonText{ get; protected set; }
	public Image UIJoysticksRotationJoystick{ get; protected set; }
	public Image UIJoysticksRotationJoystickButton{ get; protected set; }
	public TextMeshProUGUI UIJoysticksRotationJoystickButtonText{ get; protected set; }

	private void Awake()
	{
		UILeftBarMenuImage = transform.Find("LeftBarMenuImage").GetComponent<Image>();
		UILeftBarMenuImageMenuButton = transform.Find("LeftBarMenuImage/MenuButton").GetComponent<Button>();
		UILeftBarMenuImageHolder = transform.Find("LeftBarMenuImage/Holder").GetComponent<RectTransform>();
		UILeftBarMenuImageHolderMovementButton = transform.Find("LeftBarMenuImage/Holder/MovementButton").GetComponent<Button>();
		UILeftBarMenuImageHolderMovementButtonText = transform.Find("LeftBarMenuImage/Holder/MovementButton/Text").GetComponent<TextMeshProUGUI>();
		UILeftBarMenuImageHolderCreateWallButton = transform.Find("LeftBarMenuImage/Holder/CreateWallButton").GetComponent<Button>();
		UILeftBarMenuImageHolderCreateWallButtonText = transform.Find("LeftBarMenuImage/Holder/CreateWallButton/Text").GetComponent<TextMeshProUGUI>();
		UILeftBarMenuImageHolderEditWallButton = transform.Find("LeftBarMenuImage/Holder/EditWallButton").GetComponent<Button>();
		UILeftBarMenuImageHolderEditWallButtonText = transform.Find("LeftBarMenuImage/Holder/EditWallButton/Text").GetComponent<TextMeshProUGUI>();
		UILeftBarMenuImageHolderPartialWallButton = transform.Find("LeftBarMenuImage/Holder/PartialWallButton").GetComponent<Button>();
		UILeftBarMenuImageHolderPartialWallButtonText = transform.Find("LeftBarMenuImage/Holder/PartialWallButton/Text").GetComponent<TextMeshProUGUI>();
		UILeftBarMenuImageHolderEntireWallButton = transform.Find("LeftBarMenuImage/Holder/EntireWallButton").GetComponent<Button>();
		UILeftBarMenuImageHolderEntireWallButtonText = transform.Find("LeftBarMenuImage/Holder/EntireWallButton/Text").GetComponent<TextMeshProUGUI>();
		UILeftBarMenuImageHeightJoystick = transform.Find("LeftBarMenuImage/HeightJoystick").GetComponent<Image>();
		UILeftBarMenuImageHeightJoystickButton = transform.Find("LeftBarMenuImage/HeightJoystick/Button").GetComponent<Image>();
		UILeftBarMenuImageHeightJoystickButtonText = transform.Find("LeftBarMenuImage/HeightJoystick/Button/Text").GetComponent<TextMeshProUGUI>();
		UICostumizeWallType = transform.Find("CostumizeWallType").GetComponent<ScrollRect>();
		UICostumizeWallTypeSetWallColor = transform.Find("CostumizeWallType/SetWallColor").GetComponent<Button>();
		UICostumizeWallTypeSetWallColorText = transform.Find("CostumizeWallType/SetWallColor/Text").GetComponent<TextMeshProUGUI>();
		UICostumizeWallTypeSetWallType = transform.Find("CostumizeWallType/SetWallType").GetComponent<Button>();
		UICostumizeWallTypeSetWallTypeText = transform.Find("CostumizeWallType/SetWallType/Text").GetComponent<TextMeshProUGUI>();
		UICostumizeWallTypeViewport = transform.Find("CostumizeWallType/Viewport").GetComponent<Image>();
		UICostumizeWallTypeViewportContent = transform.Find("CostumizeWallType/Viewport/Content").GetComponent<RectTransform>();
		UICostumizeWallTypeScrollbarHorizontal = transform.Find("CostumizeWallType/Scrollbar Horizontal").GetComponent<Scrollbar>();
		UICostumizeWallColor = transform.Find("CostumizeWallColor").GetComponent<Image>();
		UICostumizeWallColorSetRGBColor = transform.Find("CostumizeWallColor/SetRGBColor").GetComponent<Button>();
		UICostumizeWallColorSetRGBColorText = transform.Find("CostumizeWallColor/SetRGBColor/Text").GetComponent<TextMeshProUGUI>();
		UICostumizeWallColorSetWallColor = transform.Find("CostumizeWallColor/SetWallColor").GetComponent<Button>();
		UICostumizeWallColorSetWallColorColorText = transform.Find("CostumizeWallColor/SetWallColor/ColorText").GetComponent<TextMeshProUGUI>();
		UICostumizeWallColorSetWallType = transform.Find("CostumizeWallColor/SetWallType").GetComponent<Button>();
		UICostumizeWallColorSetWallTypeTypeText = transform.Find("CostumizeWallColor/SetWallType/TypeText").GetComponent<TextMeshProUGUI>();
		UICostumizeWallColorColor0 = transform.Find("CostumizeWallColor/Color0").GetComponent<Image>();
		UICostumizeWallColorColor1 = transform.Find("CostumizeWallColor/Color1").GetComponent<Button>();
		UICostumizeWallColorColor2 = transform.Find("CostumizeWallColor/Color2").GetComponent<Button>();
		UICostumizeWallColorColor3 = transform.Find("CostumizeWallColor/Color3").GetComponent<Button>();
		UICostumizeWallColorColor4 = transform.Find("CostumizeWallColor/Color4").GetComponent<Button>();
		UICostumizeWallColorColor5 = transform.Find("CostumizeWallColor/Color5").GetComponent<Button>();
		UICostumizeWallColorColor6 = transform.Find("CostumizeWallColor/Color6").GetComponent<Button>();
		UICostumizeWallColorColor7 = transform.Find("CostumizeWallColor/Color7").GetComponent<Button>();
		UICostumizeWallColorColor8 = transform.Find("CostumizeWallColor/Color8").GetComponent<Button>();
		UICostumizeWallColorColor9 = transform.Find("CostumizeWallColor/Color9").GetComponent<Button>();
		UICostumizeWallColorColor10 = transform.Find("CostumizeWallColor/Color10").GetComponent<Button>();
		UICostumizeWallColorColor11 = transform.Find("CostumizeWallColor/Color11").GetComponent<Button>();
		UICostumizeWallColorColor12 = transform.Find("CostumizeWallColor/Color12").GetComponent<Button>();
		UICostumizeWallColorColor13 = transform.Find("CostumizeWallColor/Color13").GetComponent<Button>();
		UICostumizeWallColorColor14 = transform.Find("CostumizeWallColor/Color14").GetComponent<Button>();
		UICostumizeWallColorColor15 = transform.Find("CostumizeWallColor/Color15").GetComponent<Button>();
		UICostumizeWallColorColor16 = transform.Find("CostumizeWallColor/Color16").GetComponent<Button>();
		UICostumizeWallColorColor17 = transform.Find("CostumizeWallColor/Color17").GetComponent<Button>();
		UICostumizeWallColorColor18 = transform.Find("CostumizeWallColor/Color18").GetComponent<Button>();
		UICostumizeWallColorColor19 = transform.Find("CostumizeWallColor/Color19").GetComponent<Button>();
		UICostumizeWallColorRInputSlider = transform.Find("CostumizeWallColor/RInputSlider").GetComponent<InputSliderComponent>();
		UICostumizeWallColorGInputSlider = transform.Find("CostumizeWallColor/GInputSlider").GetComponent<InputSliderComponent>();
		UICostumizeWallColorBInputSlider = transform.Find("CostumizeWallColor/BInputSlider").GetComponent<InputSliderComponent>();
		UIMovementButtons = transform.Find("MovementButtons").GetComponent<RectTransform>();
		UIMovementButtonsTopViewButton = transform.Find("MovementButtons/TopViewButton").GetComponent<Button>();
		UIMovementButtonsTopViewButtonText = transform.Find("MovementButtons/TopViewButton/Text").GetComponent<TextMeshProUGUI>();
		UIMovementButtonsFreeRoamButton = transform.Find("MovementButtons/FreeRoamButton").GetComponent<Button>();
		UIMovementButtonsFreeRoamButtonText = transform.Find("MovementButtons/FreeRoamButton/Text").GetComponent<TextMeshProUGUI>();
		UIMovementButtonsARButton = transform.Find("MovementButtons/ARButton").GetComponent<Button>();
		UIMovementButtonsARButtonText = transform.Find("MovementButtons/ARButton/Text").GetComponent<TextMeshProUGUI>();
		UIJoysticks = transform.Find("Joysticks").GetComponent<RectTransform>();
		UIJoysticksMoveJoystick = transform.Find("Joysticks/MoveJoystick").GetComponent<Image>();
		UIJoysticksMoveJoystickButton = transform.Find("Joysticks/MoveJoystick/Button").GetComponent<Image>();
		UIJoysticksMoveJoystickButtonText = transform.Find("Joysticks/MoveJoystick/Button/Text").GetComponent<TextMeshProUGUI>();
		UIJoysticksRotationJoystick = transform.Find("Joysticks/RotationJoystick").GetComponent<Image>();
		UIJoysticksRotationJoystickButton = transform.Find("Joysticks/RotationJoystick/Button").GetComponent<Image>();
		UIJoysticksRotationJoystickButtonText = transform.Find("Joysticks/RotationJoystick/Button/Text").GetComponent<TextMeshProUGUI>();
	}
}
}
