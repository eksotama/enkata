SetCompressor /SOLID lzma

;-----------------------------------------------------------------------------------------------
; Application Information
;-----------------------------------------------------------------------------------------------
!define PRODUCT_NAME "Enkata"
!define PRODUCT_VERSION "1.0.0"
!define PRODUCT_PUBLISHER "Aris Ripandi"
!define PRODUCT_DIR "$PROGRAMFILES\${PRODUCT_NAME}"
!define PRODUCT_WEB_SITE "https://enkata.github.io"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_NAME}.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

;-----------------------------------------------------------------------------------------------
; Include Component
;-----------------------------------------------------------------------------------------------
!include x64.nsh
!include MUI2.nsh
!include FileFunc.nsh
!include DotNetChecker.nsh

;-----------------------------------------------------------------------------------------------
; MUI Settings
;-----------------------------------------------------------------------------------------------
!define MUI_ABORTWARNING
!define MUI_ICON   "Enkata.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\orange-uninstall.ico"

!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_RIGHT
!define MUI_HEADERIMAGE_BITMAP   "${NSISDIR}\Contrib\Graphics\Header\orange-r.bmp"
!define MUI_HEADERIMAGE_UNBITMAP "${NSISDIR}\Contrib\Graphics\Header\orange-uninstall-r.bmp"
 
; MUI Settings / Wizard
!define MUI_WELCOMEFINISHPAGE_BITMAP   "${NSISDIR}\Contrib\Graphics\Wizard\nsis3-metro.bmp"
!define MUI_UNWELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\orange-uninstall.bmp"

;-----------------------------------------------------------------------------------------------
; Language Selection Dialog Settings
;-----------------------------------------------------------------------------------------------
!define MUI_LANGDLL_REGISTRY_ROOT "${PRODUCT_UNINST_ROOT_KEY}"
!define MUI_LANGDLL_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_LANGDLL_REGISTRY_VALUENAME "NSIS:Language"

;-----------------------------------------------------------------------------------------------
; Page Configuration
;-----------------------------------------------------------------------------------------------
!insertmacro MUI_PAGE_WELCOME
;!define MUI_LICENSEPAGE_BUTTON
;!define MUI_LICENSEPAGE_CHECKBOX
!define MUI_LICENSEPAGE_RADIOBUTTONS
!insertmacro MUI_PAGE_LICENSE "LICENSE"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!define MUI_FINISHPAGE_RUN "$INSTDIR\${PRODUCT_NAME}.exe"
;!define MUI_FINISHPAGE_SHOWREADME "$INSTDIR\1streadme.txt"
!insertmacro MUI_PAGE_FINISH
!insertmacro MUI_UNPAGE_INSTFILES

;-----------------------------------------------------------------------------------------------
; Language files
;-----------------------------------------------------------------------------------------------
!insertmacro MUI_LANGUAGE "Afrikaans"
!insertmacro MUI_LANGUAGE "Arabic"
!insertmacro MUI_LANGUAGE "Czech"
!insertmacro MUI_LANGUAGE "Dutch"
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_LANGUAGE "Esperanto"
!insertmacro MUI_LANGUAGE "French"
!insertmacro MUI_LANGUAGE "German"
!insertmacro MUI_LANGUAGE "Indonesian"
!insertmacro MUI_LANGUAGE "Italian"
!insertmacro MUI_LANGUAGE "Japanese"
!insertmacro MUI_LANGUAGE "Korean"
!insertmacro MUI_LANGUAGE "Malay"
!insertmacro MUI_LANGUAGE "Portuguese"
!insertmacro MUI_LANGUAGE "Russian"
!insertmacro MUI_LANGUAGE "SimpChinese"
!insertmacro MUI_LANGUAGE "Spanish"
!insertmacro MUI_LANGUAGE "Thai"
!insertmacro MUI_LANGUAGE "Vietnamese"

;-----------------------------------------------------------------------------------------------
; Reserve files
;-----------------------------------------------------------------------------------------------
;!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS

;-----------------------------------------------------------------------------------------------
; Setup Information
;-----------------------------------------------------------------------------------------------
Name                   "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile                "${PRODUCT_NAME}Setup.exe"
InstallDir             "$PROGRAMFILES\${PRODUCT_NAME}"
InstallDirRegKey HKLM  "${PRODUCT_DIR_REGKEY}" ""
Caption                "${PRODUCT_NAME} Setup Wizard"
BrandingText           "${PRODUCT_NAME} version ${PRODUCT_VERSION}"
ShowInstDetails        show
ShowUnInstDetails      show
RequestExecutionLevel  admin

;-----------------------------------------------------------------------------------------------
; Functions
;-----------------------------------------------------------------------------------------------
Function .onInit
  !insertmacro MUI_LANGDLL_DISPLAY
  ${If} ${RunningX64}
    DetailPrint "Installer running on 64-bit host"
    SetRegView 64
    StrCpy $INSTDIR "$PROGRAMFILES64\${PRODUCT_NAME}"
  ${EndIf}
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
FunctionEnd

Function un.onInit
  !insertmacro MUI_UNGETLANGUAGE
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd

;-----------------------------------------------------------------------------------------------
; Setup Sections
;-----------------------------------------------------------------------------------------------

Section "MainSection" SEC01
  DetailPrint "Checking requirements"
  !insertmacro CheckNetFramework 452
  
  DetailPrint "Extracting setup files"
  ;------------------------------------------------
  ; https://www.microsoft.com/en-us/download/details.aspx?id=42642
  SetOutPath "$TEMP\"
  SetOverwrite ifnewer
  ;File "NetFx452.exe"
  ;------------------------------------------------
  SetOutPath "$TEMP\${PRODUCT_NAME}Setup64\"
  SetOverwrite ifnewer
  File "Enkata\bin\x64\Release\*.dll"
  File "Enkata\bin\x64\Release\*.bin"
  File "Enkata\bin\x64\Release\*.pak"
  File /r "Enkata\bin\x64\Release\locales"
  File "Enkata\bin\x64\Release\${PRODUCT_NAME}.exe"
  ;------------------------------------------------
  SetOutPath "$TEMP\${PRODUCT_NAME}Setup86\"
  File "Enkata\bin\x86\Release\*.dll"
  File "Enkata\bin\x86\Release\*.bin"
  File "Enkata\bin\x86\Release\*.pak"
  File /r "Enkata\bin\x86\Release\locales"
  File "Enkata\bin\x86\Release\${PRODUCT_NAME}.exe"
  ;------------------------------------------------

  DetailPrint "Creating application shortcut"
  WriteRegStr HKCU "Software\${PRODUCT_NAME}" "" $INSTDIR
  CreateDirectory "$SMPROGRAMS\$StartMenuFolder"
  CreateShortcut "$DESKTOP\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_NAME}.exe"
  CreateShortcut "$SMPROGRAMS\$StartMenuFolder\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_NAME}.exe"
  CreateShortcut "$SMPROGRAMS\$StartMenuFolder\Uninstall.lnk" "$INSTDIR\Uninstall.exe"
  WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

;Section -AdditionalIcons
;  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
;  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
;  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\uninst.exe"
;SectionEnd

Section -Post
  ;DetailPrint "Preparing requirements"
  ;ExecWait "$\"$TEMP\NetFx452.exe$\" /passive /norestart"
  
  DetailPrint "Copying required files"
  ;CreateDirectory "$INSTDIR\package"
  ${If} ${RunningX64}
      CopyFiles /SILENT "$TEMP\${PRODUCT_NAME}Setup64\*" "$INSTDIR"
  ${Else}
      CopyFiles /SILENT "$TEMP\${PRODUCT_NAME}Setup86\*" "$INSTDIR"
  ${EndIf}
  
  DetailPrint "Removing temporary files"
  RMDir /r "$TEMP\${PRODUCT_NAME}Setup64\"
  RMDir /r "$TEMP\${PRODUCT_NAME}Setup86\"

  DetailPrint "Writing application information to system"
  ${GetSize} "$INSTDIR" "/S=0K" $0 $1 $2
  IntFmt $0 "0x%08X" $0
  WriteRegDWORD HKLM "${PRODUCT_UNINST_KEY}" "EstimatedSize" "$0"

  DetailPrint "Writing uninstaller information"
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\${PRODUCT_NAME}.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\${PRODUCT_NAME}.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

Section Uninstall    
  ;Removing Installed Files
  Delete "$INSTDIR\Uninstall.exe"
  RMDir /r /REBOOTOK $INSTDIR
  Delete "$SMPROGRAMS\$StartMenuFolder\Uninstall.lnk"
  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"
  RMDir "$SMPROGRAMS\$StartMenuFolder"

  ;Removing Registri Keys
  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd
