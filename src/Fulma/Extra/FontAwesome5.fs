namespace Fulma

open Fable.Core
open Fable.Helpers.React
open Fulma

module FontAwesome5 =

    [<RequireQualifiedAccess>]
    module Fa5 =

        type IFontAwesomeIcon =
            interface end

        module I =

            [<StringEnum>]
            type FontAwesomeIcons =
                | [<CompiledName("fa-abacus")>] Abacus
                | [<CompiledName("fa-acorn")>] Acorn
                | [<CompiledName("fa-ad")>] Ad
                | [<CompiledName("fa-address-book")>] AddressBook
                | [<CompiledName("fa-address-card")>] AddressCard
                | [<CompiledName("fa-adjust")>] Adjust
                | [<CompiledName("fa-air-freshener")>] AirFreshener
                | [<CompiledName("fa-alarm-clock")>] AlarmClock
                | [<CompiledName("fa-alicorn")>] Alicorn
                | [<CompiledName("fa-align-center")>] AlignCenter
                | [<CompiledName("fa-align-justify")>] AlignJustify
                | [<CompiledName("fa-align-left")>] AlignLeft
                | [<CompiledName("fa-align-right")>] AlignRight
                | [<CompiledName("fa-allergies")>] Allergies
                | [<CompiledName("fa-ambulance")>] Ambulance
                | [<CompiledName("fa-american-sign-language-interpreting")>] AmericanSignLanguageInterpreting
                | [<CompiledName("fa-analytics")>] Analytics
                | [<CompiledName("fa-anchor")>] Anchor
                | [<CompiledName("fa-angle-double-down")>] AngleDoubleDown
                | [<CompiledName("fa-angle-double-left")>] AngleDoubleLeft
                | [<CompiledName("fa-angle-double-right")>] AngleDoubleRight
                | [<CompiledName("fa-angle-double-up")>] AngleDoubleUp
                | [<CompiledName("fa-angle-down")>] AngleDown
                | [<CompiledName("fa-angle-left")>] AngleLeft
                | [<CompiledName("fa-angle-right")>] AngleRight
                | [<CompiledName("fa-angle-up")>] AngleUp
                | [<CompiledName("fa-angry")>] Angry
                | [<CompiledName("fa-ankh")>] Ankh
                | [<CompiledName("fa-apple-alt")>] AppleAlt
                | [<CompiledName("fa-apple-crate")>] AppleCrate
                | [<CompiledName("fa-archive")>] Archive
                | [<CompiledName("fa-archway")>] Archway
                | [<CompiledName("fa-arrow-alt-circle-down")>] ArrowAltCircleDown
                | [<CompiledName("fa-arrow-alt-circle-left")>] ArrowAltCircleLeft
                | [<CompiledName("fa-arrow-alt-circle-right")>] ArrowAltCircleRight
                | [<CompiledName("fa-arrow-alt-circle-up")>] ArrowAltCircleUp
                | [<CompiledName("fa-arrow-alt-down")>] ArrowAltDown
                | [<CompiledName("fa-arrow-alt-from-bottom")>] ArrowAltFromBottom
                | [<CompiledName("fa-arrow-alt-from-left")>] ArrowAltFromLeft
                | [<CompiledName("fa-arrow-alt-from-right")>] ArrowAltFromRight
                | [<CompiledName("fa-arrow-alt-from-top")>] ArrowAltFromTop
                | [<CompiledName("fa-arrow-alt-left")>] ArrowAltLeft
                | [<CompiledName("fa-arrow-alt-right")>] ArrowAltRight
                | [<CompiledName("fa-arrow-alt-square-down")>] ArrowAltSquareDown
                | [<CompiledName("fa-arrow-alt-square-left")>] ArrowAltSquareLeft
                | [<CompiledName("fa-arrow-alt-square-right")>] ArrowAltSquareRight
                | [<CompiledName("fa-arrow-alt-square-up")>] ArrowAltSquareUp
                | [<CompiledName("fa-arrow-alt-to-bottom")>] ArrowAltToBottom
                | [<CompiledName("fa-arrow-alt-to-left")>] ArrowAltToLeft
                | [<CompiledName("fa-arrow-alt-to-right")>] ArrowAltToRight
                | [<CompiledName("fa-arrow-alt-to-top")>] ArrowAltToTop
                | [<CompiledName("fa-arrow-alt-up")>] ArrowAltUp
                | [<CompiledName("fa-arrow-circle-down")>] ArrowCircleDown
                | [<CompiledName("fa-arrow-circle-left")>] ArrowCircleLeft
                | [<CompiledName("fa-arrow-circle-right")>] ArrowCircleRight
                | [<CompiledName("fa-arrow-circle-up")>] ArrowCircleUp
                | [<CompiledName("fa-arrow-down")>] ArrowDown
                | [<CompiledName("fa-arrow-from-bottom")>] ArrowFromBottom
                | [<CompiledName("fa-arrow-from-left")>] ArrowFromLeft
                | [<CompiledName("fa-arrow-from-right")>] ArrowFromRight
                | [<CompiledName("fa-arrow-from-top")>] ArrowFromTop
                | [<CompiledName("fa-arrow-left")>] ArrowLeft
                | [<CompiledName("fa-arrow-right")>] ArrowRight
                | [<CompiledName("fa-arrow-square-down")>] ArrowSquareDown
                | [<CompiledName("fa-arrow-square-left")>] ArrowSquareLeft
                | [<CompiledName("fa-arrow-square-right")>] ArrowSquareRight
                | [<CompiledName("fa-arrow-square-up")>] ArrowSquareUp
                | [<CompiledName("fa-arrow-to-bottom")>] ArrowToBottom
                | [<CompiledName("fa-arrow-to-left")>] ArrowToLeft
                | [<CompiledName("fa-arrow-to-right")>] ArrowToRight
                | [<CompiledName("fa-arrow-to-top")>] ArrowToTop
                | [<CompiledName("fa-arrow-up")>] ArrowUp
                | [<CompiledName("fa-arrows")>] Arrows
                | [<CompiledName("fa-arrows-alt")>] ArrowsAlt
                | [<CompiledName("fa-arrows-alt-h")>] ArrowsAltH
                | [<CompiledName("fa-arrows-alt-v")>] ArrowsAltV
                | [<CompiledName("fa-arrows-h")>] ArrowsH
                | [<CompiledName("fa-arrows-v")>] ArrowsV
                | [<CompiledName("fa-assistive-listening-systems")>] AssistiveListeningSystems
                | [<CompiledName("fa-asterisk")>] Asterisk
                | [<CompiledName("fa-at")>] At
                | [<CompiledName("fa-atlas")>] Atlas
                | [<CompiledName("fa-atom")>] Atom
                | [<CompiledName("fa-atom-alt")>] AtomAlt
                | [<CompiledName("fa-audio-description")>] AudioDescription
                | [<CompiledName("fa-award")>] Award
                | [<CompiledName("fa-axe")>] Axe
                | [<CompiledName("fa-axe-battle")>] AxeBattle
                | [<CompiledName("fa-backpack")>] Backpack
                | [<CompiledName("fa-backspace")>] Backspace
                | [<CompiledName("fa-backward")>] Backward
                | [<CompiledName("fa-badge")>] Badge
                | [<CompiledName("fa-badge-check")>] BadgeCheck
                | [<CompiledName("fa-badge-dollar")>] BadgeDollar
                | [<CompiledName("fa-badge-percent")>] BadgePercent
                | [<CompiledName("fa-badger-honey")>] BadgerHoney
                | [<CompiledName("fa-balance-scale")>] BalanceScale
                | [<CompiledName("fa-balance-scale-left")>] BalanceScaleLeft
                | [<CompiledName("fa-balance-scale-right")>] BalanceScaleRight
                | [<CompiledName("fa-ban")>] Ban
                | [<CompiledName("fa-band-aid")>] BandAid
                | [<CompiledName("fa-barcode")>] Barcode
                | [<CompiledName("fa-barcode-alt")>] BarcodeAlt
                | [<CompiledName("fa-barcode-read")>] BarcodeRead
                | [<CompiledName("fa-barcode-scan")>] BarcodeScan
                | [<CompiledName("fa-bars")>] Bars
                | [<CompiledName("fa-baseball")>] Baseball
                | [<CompiledName("fa-baseball-ball")>] BaseballBall
                | [<CompiledName("fa-basketball-ball")>] BasketballBall
                | [<CompiledName("fa-basketball-hoop")>] BasketballHoop
                | [<CompiledName("fa-bat")>] Bat
                | [<CompiledName("fa-bath")>] Bath
                | [<CompiledName("fa-battery-bolt")>] BatteryBolt
                | [<CompiledName("fa-battery-empty")>] BatteryEmpty
                | [<CompiledName("fa-battery-full")>] BatteryFull
                | [<CompiledName("fa-battery-half")>] BatteryHalf
                | [<CompiledName("fa-battery-quarter")>] BatteryQuarter
                | [<CompiledName("fa-battery-slash")>] BatterySlash
                | [<CompiledName("fa-battery-three-quarters")>] BatteryThreeQuarters
                | [<CompiledName("fa-bed")>] Bed
                | [<CompiledName("fa-beer")>] Beer
                | [<CompiledName("fa-bell")>] Bell
                | [<CompiledName("fa-bell-school")>] BellSchool
                | [<CompiledName("fa-bell-school-slash")>] BellSchoolSlash
                | [<CompiledName("fa-bell-slash")>] BellSlash
                | [<CompiledName("fa-bezier-curve")>] BezierCurve
                | [<CompiledName("fa-bible")>] Bible
                | [<CompiledName("fa-bicycle")>] Bicycle
                | [<CompiledName("fa-binoculars")>] Binoculars
                | [<CompiledName("fa-birthday-cake")>] BirthdayCake
                | [<CompiledName("fa-blanket")>] Blanket
                | [<CompiledName("fa-blender")>] Blender
                | [<CompiledName("fa-blender-phone")>] BlenderPhone
                | [<CompiledName("fa-blind")>] Blind
                | [<CompiledName("fa-bold")>] Bold
                | [<CompiledName("fa-bolt")>] Bolt
                | [<CompiledName("fa-bomb")>] Bomb
                | [<CompiledName("fa-bone")>] Bone
                | [<CompiledName("fa-bone-break")>] BoneBreak
                | [<CompiledName("fa-bong")>] Bong
                | [<CompiledName("fa-book")>] Book
                | [<CompiledName("fa-book-alt")>] BookAlt
                | [<CompiledName("fa-book-dead")>] BookDead
                | [<CompiledName("fa-book-heart")>] BookHeart
                | [<CompiledName("fa-book-open")>] BookOpen
                | [<CompiledName("fa-book-reader")>] BookReader
                | [<CompiledName("fa-book-spells")>] BookSpells
                | [<CompiledName("fa-bookmark")>] Bookmark
                | [<CompiledName("fa-books")>] Books
                | [<CompiledName("fa-bow-arrow")>] BowArrow
                | [<CompiledName("fa-bowling-ball")>] BowlingBall
                | [<CompiledName("fa-bowling-pins")>] BowlingPins
                | [<CompiledName("fa-box")>] Box
                | [<CompiledName("fa-box-alt")>] BoxAlt
                | [<CompiledName("fa-box-check")>] BoxCheck
                | [<CompiledName("fa-box-fragile")>] BoxFragile
                | [<CompiledName("fa-box-full")>] BoxFull
                | [<CompiledName("fa-box-heart")>] BoxHeart
                | [<CompiledName("fa-box-open")>] BoxOpen
                | [<CompiledName("fa-box-up")>] BoxUp
                | [<CompiledName("fa-box-usd")>] BoxUsd
                | [<CompiledName("fa-boxes")>] Boxes
                | [<CompiledName("fa-boxes-alt")>] BoxesAlt
                | [<CompiledName("fa-boxing-glove")>] BoxingGlove
                | [<CompiledName("fa-braille")>] Braille
                | [<CompiledName("fa-brain")>] Brain
                | [<CompiledName("fa-briefcase")>] Briefcase
                | [<CompiledName("fa-briefcase-medical")>] BriefcaseMedical
                | [<CompiledName("fa-broadcast-tower")>] BroadcastTower
                | [<CompiledName("fa-broom")>] Broom
                | [<CompiledName("fa-browser")>] Browser
                | [<CompiledName("fa-brush")>] Brush
                | [<CompiledName("fa-bug")>] Bug
                | [<CompiledName("fa-building")>] Building
                | [<CompiledName("fa-bullhorn")>] Bullhorn
                | [<CompiledName("fa-bullseye")>] Bullseye
                | [<CompiledName("fa-bullseye-arrow")>] BullseyeArrow
                | [<CompiledName("fa-bullseye-pointer")>] BullseyePointer
                | [<CompiledName("fa-burn")>] Burn
                | [<CompiledName("fa-bus")>] Bus
                | [<CompiledName("fa-bus-alt")>] BusAlt
                | [<CompiledName("fa-bus-school")>] BusSchool
                | [<CompiledName("fa-business-time")>] BusinessTime
                | [<CompiledName("fa-cabinet-filing")>] CabinetFiling
                | [<CompiledName("fa-calculator")>] Calculator
                | [<CompiledName("fa-calculator-alt")>] CalculatorAlt
                | [<CompiledName("fa-calendar")>] Calendar
                | [<CompiledName("fa-calendar-alt")>] CalendarAlt
                | [<CompiledName("fa-calendar-check")>] CalendarCheck
                | [<CompiledName("fa-calendar-edit")>] CalendarEdit
                | [<CompiledName("fa-calendar-exclamation")>] CalendarExclamation
                | [<CompiledName("fa-calendar-minus")>] CalendarMinus
                | [<CompiledName("fa-calendar-plus")>] CalendarPlus
                | [<CompiledName("fa-calendar-times")>] CalendarTimes
                | [<CompiledName("fa-camera")>] Camera
                | [<CompiledName("fa-camera-alt")>] CameraAlt
                | [<CompiledName("fa-camera-retro")>] CameraRetro
                | [<CompiledName("fa-campfire")>] Campfire
                | [<CompiledName("fa-campground")>] Campground
                | [<CompiledName("fa-candle-holder")>] CandleHolder
                | [<CompiledName("fa-candy-corn")>] CandyCorn
                | [<CompiledName("fa-cannabis")>] Cannabis
                | [<CompiledName("fa-capsules")>] Capsules
                | [<CompiledName("fa-car")>] Car
                | [<CompiledName("fa-car-alt")>] CarAlt
                | [<CompiledName("fa-car-battery")>] CarBattery
                | [<CompiledName("fa-car-bump")>] CarBump
                | [<CompiledName("fa-car-crash")>] CarCrash
                | [<CompiledName("fa-car-garage")>] CarGarage
                | [<CompiledName("fa-car-mechanic")>] CarMechanic
                | [<CompiledName("fa-car-side")>] CarSide
                | [<CompiledName("fa-car-tilt")>] CarTilt
                | [<CompiledName("fa-car-wash")>] CarWash
                | [<CompiledName("fa-caret-circle-down")>] CaretCircleDown
                | [<CompiledName("fa-caret-circle-left")>] CaretCircleLeft
                | [<CompiledName("fa-caret-circle-right")>] CaretCircleRight
                | [<CompiledName("fa-caret-circle-up")>] CaretCircleUp
                | [<CompiledName("fa-caret-down")>] CaretDown
                | [<CompiledName("fa-caret-left")>] CaretLeft
                | [<CompiledName("fa-caret-right")>] CaretRight
                | [<CompiledName("fa-caret-square-down")>] CaretSquareDown
                | [<CompiledName("fa-caret-square-left")>] CaretSquareLeft
                | [<CompiledName("fa-caret-square-right")>] CaretSquareRight
                | [<CompiledName("fa-caret-square-up")>] CaretSquareUp
                | [<CompiledName("fa-caret-up")>] CaretUp
                | [<CompiledName("fa-cart-arrow-down")>] CartArrowDown
                | [<CompiledName("fa-cart-plus")>] CartPlus
                | [<CompiledName("fa-cat")>] Cat
                | [<CompiledName("fa-cauldron")>] Cauldron
                | [<CompiledName("fa-certificate")>] Certificate
                | [<CompiledName("fa-chair")>] Chair
                | [<CompiledName("fa-chair-office")>] ChairOffice
                | [<CompiledName("fa-chalkboard")>] Chalkboard
                | [<CompiledName("fa-chalkboard-teacher")>] ChalkboardTeacher
                | [<CompiledName("fa-charging-station")>] ChargingStation
                | [<CompiledName("fa-chart-area")>] ChartArea
                | [<CompiledName("fa-chart-bar")>] ChartBar
                | [<CompiledName("fa-chart-line")>] ChartLine
                | [<CompiledName("fa-chart-line-down")>] ChartLineDown
                | [<CompiledName("fa-chart-pie")>] ChartPie
                | [<CompiledName("fa-chart-pie-alt")>] ChartPieAlt
                | [<CompiledName("fa-check")>] Check
                | [<CompiledName("fa-check-circle")>] CheckCircle
                | [<CompiledName("fa-check-double")>] CheckDouble
                | [<CompiledName("fa-check-square")>] CheckSquare
                | [<CompiledName("fa-chess")>] Chess
                | [<CompiledName("fa-chess-bishop")>] ChessBishop
                | [<CompiledName("fa-chess-bishop-alt")>] ChessBishopAlt
                | [<CompiledName("fa-chess-board")>] ChessBoard
                | [<CompiledName("fa-chess-clock")>] ChessClock
                | [<CompiledName("fa-chess-clock-alt")>] ChessClockAlt
                | [<CompiledName("fa-chess-king")>] ChessKing
                | [<CompiledName("fa-chess-king-alt")>] ChessKingAlt
                | [<CompiledName("fa-chess-knight")>] ChessKnight
                | [<CompiledName("fa-chess-knight-alt")>] ChessKnightAlt
                | [<CompiledName("fa-chess-pawn")>] ChessPawn
                | [<CompiledName("fa-chess-pawn-alt")>] ChessPawnAlt
                | [<CompiledName("fa-chess-queen")>] ChessQueen
                | [<CompiledName("fa-chess-queen-alt")>] ChessQueenAlt
                | [<CompiledName("fa-chess-rook")>] ChessRook
                | [<CompiledName("fa-chess-rook-alt")>] ChessRookAlt
                | [<CompiledName("fa-chevron-circle-down")>] ChevronCircleDown
                | [<CompiledName("fa-chevron-circle-left")>] ChevronCircleLeft
                | [<CompiledName("fa-chevron-circle-right")>] ChevronCircleRight
                | [<CompiledName("fa-chevron-circle-up")>] ChevronCircleUp
                | [<CompiledName("fa-chevron-double-down")>] ChevronDoubleDown
                | [<CompiledName("fa-chevron-double-left")>] ChevronDoubleLeft
                | [<CompiledName("fa-chevron-double-right")>] ChevronDoubleRight
                | [<CompiledName("fa-chevron-double-up")>] ChevronDoubleUp
                | [<CompiledName("fa-chevron-down")>] ChevronDown
                | [<CompiledName("fa-chevron-left")>] ChevronLeft
                | [<CompiledName("fa-chevron-right")>] ChevronRight
                | [<CompiledName("fa-chevron-square-down")>] ChevronSquareDown
                | [<CompiledName("fa-chevron-square-left")>] ChevronSquareLeft
                | [<CompiledName("fa-chevron-square-right")>] ChevronSquareRight
                | [<CompiledName("fa-chevron-square-up")>] ChevronSquareUp
                | [<CompiledName("fa-chevron-up")>] ChevronUp
                | [<CompiledName("fa-child")>] Child
                | [<CompiledName("fa-church")>] Church
                | [<CompiledName("fa-circle")>] Circle
                | [<CompiledName("fa-circle-notch")>] CircleNotch
                | [<CompiledName("fa-city")>] City
                | [<CompiledName("fa-claw-marks")>] ClawMarks
                | [<CompiledName("fa-clipboard")>] Clipboard
                | [<CompiledName("fa-clipboard-check")>] ClipboardCheck
                | [<CompiledName("fa-clipboard-list")>] ClipboardList
                | [<CompiledName("fa-clipboard-prescription")>] ClipboardPrescription
                | [<CompiledName("fa-clock")>] Clock
                | [<CompiledName("fa-clone")>] Clone
                | [<CompiledName("fa-closed-captioning")>] ClosedCaptioning
                | [<CompiledName("fa-cloud")>] Cloud
                | [<CompiledName("fa-cloud-download")>] CloudDownload
                | [<CompiledName("fa-cloud-download-alt")>] CloudDownloadAlt
                | [<CompiledName("fa-cloud-moon")>] CloudMoon
                | [<CompiledName("fa-cloud-sun")>] CloudSun
                | [<CompiledName("fa-cloud-upload")>] CloudUpload
                | [<CompiledName("fa-cloud-upload-alt")>] CloudUploadAlt
                | [<CompiledName("fa-club")>] Club
                | [<CompiledName("fa-cocktail")>] Cocktail
                | [<CompiledName("fa-code")>] Code
                | [<CompiledName("fa-code-branch")>] CodeBranch
                | [<CompiledName("fa-code-commit")>] CodeCommit
                | [<CompiledName("fa-code-merge")>] CodeMerge
                | [<CompiledName("fa-coffee")>] Coffee
                | [<CompiledName("fa-coffee-togo")>] CoffeeTogo
                | [<CompiledName("fa-coffin")>] Coffin
                | [<CompiledName("fa-cog")>] Cog
                | [<CompiledName("fa-cogs")>] Cogs
                | [<CompiledName("fa-coins")>] Coins
                | [<CompiledName("fa-columns")>] Columns
                | [<CompiledName("fa-comment")>] Comment
                | [<CompiledName("fa-comment-alt")>] CommentAlt
                | [<CompiledName("fa-comment-alt-check")>] CommentAltCheck
                | [<CompiledName("fa-comment-alt-dollar")>] CommentAltDollar
                | [<CompiledName("fa-comment-alt-dots")>] CommentAltDots
                | [<CompiledName("fa-comment-alt-edit")>] CommentAltEdit
                | [<CompiledName("fa-comment-alt-exclamation")>] CommentAltExclamation
                | [<CompiledName("fa-comment-alt-lines")>] CommentAltLines
                | [<CompiledName("fa-comment-alt-minus")>] CommentAltMinus
                | [<CompiledName("fa-comment-alt-plus")>] CommentAltPlus
                | [<CompiledName("fa-comment-alt-slash")>] CommentAltSlash
                | [<CompiledName("fa-comment-alt-smile")>] CommentAltSmile
                | [<CompiledName("fa-comment-alt-times")>] CommentAltTimes
                | [<CompiledName("fa-comment-check")>] CommentCheck
                | [<CompiledName("fa-comment-dollar")>] CommentDollar
                | [<CompiledName("fa-comment-dots")>] CommentDots
                | [<CompiledName("fa-comment-edit")>] CommentEdit
                | [<CompiledName("fa-comment-exclamation")>] CommentExclamation
                | [<CompiledName("fa-comment-lines")>] CommentLines
                | [<CompiledName("fa-comment-minus")>] CommentMinus
                | [<CompiledName("fa-comment-plus")>] CommentPlus
                | [<CompiledName("fa-comment-slash")>] CommentSlash
                | [<CompiledName("fa-comment-smile")>] CommentSmile
                | [<CompiledName("fa-comment-times")>] CommentTimes
                | [<CompiledName("fa-comments")>] Comments
                | [<CompiledName("fa-comments-alt")>] CommentsAlt
                | [<CompiledName("fa-comments-alt-dollar")>] CommentsAltDollar
                | [<CompiledName("fa-comments-dollar")>] CommentsDollar
                | [<CompiledName("fa-compact-disc")>] CompactDisc
                | [<CompiledName("fa-compass")>] Compass
                | [<CompiledName("fa-compass-slash")>] CompassSlash
                | [<CompiledName("fa-compress")>] Compress
                | [<CompiledName("fa-compress-alt")>] CompressAlt
                | [<CompiledName("fa-compress-wide")>] CompressWide
                | [<CompiledName("fa-concierge-bell")>] ConciergeBell
                | [<CompiledName("fa-container-storage")>] ContainerStorage
                | [<CompiledName("fa-conveyor-belt")>] ConveyorBelt
                | [<CompiledName("fa-conveyor-belt-alt")>] ConveyorBeltAlt
                | [<CompiledName("fa-cookie")>] Cookie
                | [<CompiledName("fa-cookie-bite")>] CookieBite
                | [<CompiledName("fa-copy")>] Copy
                | [<CompiledName("fa-copyright")>] Copyright
                | [<CompiledName("fa-corn")>] Corn
                | [<CompiledName("fa-couch")>] Couch
                | [<CompiledName("fa-cow")>] Cow
                | [<CompiledName("fa-credit-card")>] CreditCard
                | [<CompiledName("fa-credit-card-blank")>] CreditCardBlank
                | [<CompiledName("fa-credit-card-front")>] CreditCardFront
                | [<CompiledName("fa-cricket")>] Cricket
                | [<CompiledName("fa-crop")>] Crop
                | [<CompiledName("fa-crop-alt")>] CropAlt
                | [<CompiledName("fa-cross")>] Cross
                | [<CompiledName("fa-crosshairs")>] Crosshairs
                | [<CompiledName("fa-crow")>] Crow
                | [<CompiledName("fa-crown")>] Crown
                | [<CompiledName("fa-cube")>] Cube
                | [<CompiledName("fa-cubes")>] Cubes
                | [<CompiledName("fa-curling")>] Curling
                | [<CompiledName("fa-cut")>] Cut
                | [<CompiledName("fa-dagger")>] Dagger
                | [<CompiledName("fa-database")>] Database
                | [<CompiledName("fa-deaf")>] Deaf
                | [<CompiledName("fa-desktop")>] Desktop
                | [<CompiledName("fa-desktop-alt")>] DesktopAlt
                | [<CompiledName("fa-dharmachakra")>] Dharmachakra
                | [<CompiledName("fa-diagnoses")>] Diagnoses
                | [<CompiledName("fa-diamond")>] Diamond
                | [<CompiledName("fa-dice")>] Dice
                | [<CompiledName("fa-dice-d10")>] DiceD10
                | [<CompiledName("fa-dice-d12")>] DiceD12
                | [<CompiledName("fa-dice-d20")>] DiceD20
                | [<CompiledName("fa-dice-d4")>] DiceD4
                | [<CompiledName("fa-dice-d6")>] DiceD6
                | [<CompiledName("fa-dice-d8")>] DiceD8
                | [<CompiledName("fa-dice-five")>] DiceFive
                | [<CompiledName("fa-dice-four")>] DiceFour
                | [<CompiledName("fa-dice-one")>] DiceOne
                | [<CompiledName("fa-dice-six")>] DiceSix
                | [<CompiledName("fa-dice-three")>] DiceThree
                | [<CompiledName("fa-dice-two")>] DiceTwo
                | [<CompiledName("fa-digital-tachograph")>] DigitalTachograph
                | [<CompiledName("fa-diploma")>] Diploma
                | [<CompiledName("fa-directions")>] Directions
                | [<CompiledName("fa-divide")>] Divide
                | [<CompiledName("fa-dizzy")>] Dizzy
                | [<CompiledName("fa-dna")>] Dna
                | [<CompiledName("fa-do-not-enter")>] DoNotEnter
                | [<CompiledName("fa-dog")>] Dog
                | [<CompiledName("fa-dog-leashed")>] DogLeashed
                | [<CompiledName("fa-dollar-sign")>] DollarSign
                | [<CompiledName("fa-dolly")>] Dolly
                | [<CompiledName("fa-dolly-empty")>] DollyEmpty
                | [<CompiledName("fa-dolly-flatbed")>] DollyFlatbed
                | [<CompiledName("fa-dolly-flatbed-alt")>] DollyFlatbedAlt
                | [<CompiledName("fa-dolly-flatbed-empty")>] DollyFlatbedEmpty
                | [<CompiledName("fa-donate")>] Donate
                | [<CompiledName("fa-door-closed")>] DoorClosed
                | [<CompiledName("fa-door-open")>] DoorOpen
                | [<CompiledName("fa-dot-circle")>] DotCircle
                | [<CompiledName("fa-dove")>] Dove
                | [<CompiledName("fa-download")>] Download
                | [<CompiledName("fa-drafting-compass")>] DraftingCompass
                | [<CompiledName("fa-dragon")>] Dragon
                | [<CompiledName("fa-draw-circle")>] DrawCircle
                | [<CompiledName("fa-draw-polygon")>] DrawPolygon
                | [<CompiledName("fa-draw-square")>] DrawSquare
                | [<CompiledName("fa-drum")>] Drum
                | [<CompiledName("fa-drum-steelpan")>] DrumSteelpan
                | [<CompiledName("fa-drumstick")>] Drumstick
                | [<CompiledName("fa-drumstick-bite")>] DrumstickBite
                | [<CompiledName("fa-duck")>] Duck
                | [<CompiledName("fa-dumbbell")>] Dumbbell
                | [<CompiledName("fa-dungeon")>] Dungeon
                | [<CompiledName("fa-ear")>] Ear
                | [<CompiledName("fa-edit")>] Edit
                | [<CompiledName("fa-eject")>] Eject
                | [<CompiledName("fa-elephant")>] Elephant
                | [<CompiledName("fa-ellipsis-h")>] EllipsisH
                | [<CompiledName("fa-ellipsis-h-alt")>] EllipsisHAlt
                | [<CompiledName("fa-ellipsis-v")>] EllipsisV
                | [<CompiledName("fa-ellipsis-v-alt")>] EllipsisVAlt
                | [<CompiledName("fa-empty-set")>] EmptySet
                | [<CompiledName("fa-engine-warning")>] EngineWarning
                | [<CompiledName("fa-envelope")>] Envelope
                | [<CompiledName("fa-envelope-open")>] EnvelopeOpen
                | [<CompiledName("fa-envelope-open-dollar")>] EnvelopeOpenDollar
                | [<CompiledName("fa-envelope-open-text")>] EnvelopeOpenText
                | [<CompiledName("fa-envelope-square")>] EnvelopeSquare
                | [<CompiledName("fa-equals")>] Equals
                | [<CompiledName("fa-eraser")>] Eraser
                | [<CompiledName("fa-euro-sign")>] EuroSign
                | [<CompiledName("fa-exchange")>] Exchange
                | [<CompiledName("fa-exchange-alt")>] ExchangeAlt
                | [<CompiledName("fa-exclamation")>] Exclamation
                | [<CompiledName("fa-exclamation-circle")>] ExclamationCircle
                | [<CompiledName("fa-exclamation-square")>] ExclamationSquare
                | [<CompiledName("fa-exclamation-triangle")>] ExclamationTriangle
                | [<CompiledName("fa-expand")>] Expand
                | [<CompiledName("fa-expand-alt")>] ExpandAlt
                | [<CompiledName("fa-expand-arrows")>] ExpandArrows
                | [<CompiledName("fa-expand-arrows-alt")>] ExpandArrowsAlt
                | [<CompiledName("fa-expand-wide")>] ExpandWide
                | [<CompiledName("fa-external-link")>] ExternalLink
                | [<CompiledName("fa-external-link-alt")>] ExternalLinkAlt
                | [<CompiledName("fa-external-link-square")>] ExternalLinkSquare
                | [<CompiledName("fa-external-link-square-alt")>] ExternalLinkSquareAlt
                | [<CompiledName("fa-eye")>] Eye
                | [<CompiledName("fa-eye-dropper")>] EyeDropper
                | [<CompiledName("fa-eye-evil")>] EyeEvil
                | [<CompiledName("fa-eye-slash")>] EyeSlash
                | [<CompiledName("fa-fast-backward")>] FastBackward
                | [<CompiledName("fa-fast-forward")>] FastForward
                | [<CompiledName("fa-fax")>] Fax
                | [<CompiledName("fa-feather")>] Feather
                | [<CompiledName("fa-feather-alt")>] FeatherAlt
                | [<CompiledName("fa-female")>] Female
                | [<CompiledName("fa-field-hockey")>] FieldHockey
                | [<CompiledName("fa-fighter-jet")>] FighterJet
                | [<CompiledName("fa-file")>] File
                | [<CompiledName("fa-file-alt")>] FileAlt
                | [<CompiledName("fa-file-archive")>] FileArchive
                | [<CompiledName("fa-file-audio")>] FileAudio
                | [<CompiledName("fa-file-certificate")>] FileCertificate
                | [<CompiledName("fa-file-chart-line")>] FileChartLine
                | [<CompiledName("fa-file-chart-pie")>] FileChartPie
                | [<CompiledName("fa-file-check")>] FileCheck
                | [<CompiledName("fa-file-code")>] FileCode
                | [<CompiledName("fa-file-contract")>] FileContract
                | [<CompiledName("fa-file-csv")>] FileCsv
                | [<CompiledName("fa-file-download")>] FileDownload
                | [<CompiledName("fa-file-edit")>] FileEdit
                | [<CompiledName("fa-file-excel")>] FileExcel
                | [<CompiledName("fa-file-exclamation")>] FileExclamation
                | [<CompiledName("fa-file-export")>] FileExport
                | [<CompiledName("fa-file-image")>] FileImage
                | [<CompiledName("fa-file-import")>] FileImport
                | [<CompiledName("fa-file-invoice")>] FileInvoice
                | [<CompiledName("fa-file-invoice-dollar")>] FileInvoiceDollar
                | [<CompiledName("fa-file-medical")>] FileMedical
                | [<CompiledName("fa-file-medical-alt")>] FileMedicalAlt
                | [<CompiledName("fa-file-minus")>] FileMinus
                | [<CompiledName("fa-file-pdf")>] FilePdf
                | [<CompiledName("fa-file-plus")>] FilePlus
                | [<CompiledName("fa-file-powerpoint")>] FilePowerpoint
                | [<CompiledName("fa-file-prescription")>] FilePrescription
                | [<CompiledName("fa-file-signature")>] FileSignature
                | [<CompiledName("fa-file-spreadsheet")>] FileSpreadsheet
                | [<CompiledName("fa-file-times")>] FileTimes
                | [<CompiledName("fa-file-upload")>] FileUpload
                | [<CompiledName("fa-file-user")>] FileUser
                | [<CompiledName("fa-file-video")>] FileVideo
                | [<CompiledName("fa-file-word")>] FileWord
                | [<CompiledName("fa-fill")>] Fill
                | [<CompiledName("fa-fill-drip")>] FillDrip
                | [<CompiledName("fa-film")>] Film
                | [<CompiledName("fa-film-alt")>] FilmAlt
                | [<CompiledName("fa-filter")>] Filter
                | [<CompiledName("fa-fingerprint")>] Fingerprint
                | [<CompiledName("fa-fire")>] Fire
                | [<CompiledName("fa-fire-extinguisher")>] FireExtinguisher
                | [<CompiledName("fa-first-aid")>] FirstAid
                | [<CompiledName("fa-fish")>] Fish
                | [<CompiledName("fa-fist-raised")>] FistRaised
                | [<CompiledName("fa-flag")>] Flag
                | [<CompiledName("fa-flag-checkered")>] FlagCheckered
                | [<CompiledName("fa-flame")>] Flame
                | [<CompiledName("fa-flask")>] Flask
                | [<CompiledName("fa-flask-poison")>] FlaskPoison
                | [<CompiledName("fa-flask-potion")>] FlaskPotion
                | [<CompiledName("fa-flushed")>] Flushed
                | [<CompiledName("fa-folder")>] Folder
                | [<CompiledName("fa-folder-minus")>] FolderMinus
                | [<CompiledName("fa-folder-open")>] FolderOpen
                | [<CompiledName("fa-folder-plus")>] FolderPlus
                | [<CompiledName("fa-folder-times")>] FolderTimes
                | [<CompiledName("fa-folders")>] Folders
                | [<CompiledName("fa-font")>] Font
                | [<CompiledName("fa-font-awesome-logo-full")>] FontAwesomeLogoFull
                | [<CompiledName("fa-football-ball")>] FootballBall
                | [<CompiledName("fa-football-helmet")>] FootballHelmet
                | [<CompiledName("fa-forklift")>] Forklift
                | [<CompiledName("fa-forward")>] Forward
                | [<CompiledName("fa-fragile")>] Fragile
                | [<CompiledName("fa-frog")>] Frog
                | [<CompiledName("fa-frown")>] Frown
                | [<CompiledName("fa-frown-open")>] FrownOpen
                | [<CompiledName("fa-function")>] Function
                | [<CompiledName("fa-funnel-dollar")>] FunnelDollar
                | [<CompiledName("fa-futbol")>] Futbol
                | [<CompiledName("fa-gamepad")>] Gamepad
                | [<CompiledName("fa-gas-pump")>] GasPump
                | [<CompiledName("fa-gas-pump-slash")>] GasPumpSlash
                | [<CompiledName("fa-gavel")>] Gavel
                | [<CompiledName("fa-gem")>] Gem
                | [<CompiledName("fa-genderless")>] Genderless
                | [<CompiledName("fa-ghost")>] Ghost
                | [<CompiledName("fa-gift")>] Gift
                | [<CompiledName("fa-gift-card")>] GiftCard
                | [<CompiledName("fa-glass-martini")>] GlassMartini
                | [<CompiledName("fa-glass-martini-alt")>] GlassMartiniAlt
                | [<CompiledName("fa-glasses")>] Glasses
                | [<CompiledName("fa-glasses-alt")>] GlassesAlt
                | [<CompiledName("fa-globe")>] Globe
                | [<CompiledName("fa-globe-africa")>] GlobeAfrica
                | [<CompiledName("fa-globe-americas")>] GlobeAmericas
                | [<CompiledName("fa-globe-asia")>] GlobeAsia
                | [<CompiledName("fa-globe-stand")>] GlobeStand
                | [<CompiledName("fa-golf-ball")>] GolfBall
                | [<CompiledName("fa-golf-club")>] GolfClub
                | [<CompiledName("fa-gopuram")>] Gopuram
                | [<CompiledName("fa-graduation-cap")>] GraduationCap
                | [<CompiledName("fa-greater-than")>] GreaterThan
                | [<CompiledName("fa-greater-than-equal")>] GreaterThanEqual
                | [<CompiledName("fa-grimace")>] Grimace
                | [<CompiledName("fa-grin")>] Grin
                | [<CompiledName("fa-grin-alt")>] GrinAlt
                | [<CompiledName("fa-grin-beam")>] GrinBeam
                | [<CompiledName("fa-grin-beam-sweat")>] GrinBeamSweat
                | [<CompiledName("fa-grin-hearts")>] GrinHearts
                | [<CompiledName("fa-grin-squint")>] GrinSquint
                | [<CompiledName("fa-grin-squint-tears")>] GrinSquintTears
                | [<CompiledName("fa-grin-stars")>] GrinStars
                | [<CompiledName("fa-grin-tears")>] GrinTears
                | [<CompiledName("fa-grin-tongue")>] GrinTongue
                | [<CompiledName("fa-grin-tongue-squint")>] GrinTongueSquint
                | [<CompiledName("fa-grin-tongue-wink")>] GrinTongueWink
                | [<CompiledName("fa-grin-wink")>] GrinWink
                | [<CompiledName("fa-grip-horizontal")>] GripHorizontal
                | [<CompiledName("fa-grip-vertical")>] GripVertical
                | [<CompiledName("fa-h-square")>] HSquare
                | [<CompiledName("fa-h1")>] H1
                | [<CompiledName("fa-h2")>] H2
                | [<CompiledName("fa-h3")>] H3
                | [<CompiledName("fa-hammer")>] Hammer
                | [<CompiledName("fa-hammer-war")>] HammerWar
                | [<CompiledName("fa-hamsa")>] Hamsa
                | [<CompiledName("fa-hand-heart")>] HandHeart
                | [<CompiledName("fa-hand-holding")>] HandHolding
                | [<CompiledName("fa-hand-holding-box")>] HandHoldingBox
                | [<CompiledName("fa-hand-holding-heart")>] HandHoldingHeart
                | [<CompiledName("fa-hand-holding-magic")>] HandHoldingMagic
                | [<CompiledName("fa-hand-holding-seedling")>] HandHoldingSeedling
                | [<CompiledName("fa-hand-holding-usd")>] HandHoldingUsd
                | [<CompiledName("fa-hand-holding-water")>] HandHoldingWater
                | [<CompiledName("fa-hand-lizard")>] HandLizard
                | [<CompiledName("fa-hand-paper")>] HandPaper
                | [<CompiledName("fa-hand-peace")>] HandPeace
                | [<CompiledName("fa-hand-point-down")>] HandPointDown
                | [<CompiledName("fa-hand-point-left")>] HandPointLeft
                | [<CompiledName("fa-hand-point-right")>] HandPointRight
                | [<CompiledName("fa-hand-point-up")>] HandPointUp
                | [<CompiledName("fa-hand-pointer")>] HandPointer
                | [<CompiledName("fa-hand-receiving")>] HandReceiving
                | [<CompiledName("fa-hand-rock")>] HandRock
                | [<CompiledName("fa-hand-scissors")>] HandScissors
                | [<CompiledName("fa-hand-spock")>] HandSpock
                | [<CompiledName("fa-hands")>] Hands
                | [<CompiledName("fa-hands-heart")>] HandsHeart
                | [<CompiledName("fa-hands-helping")>] HandsHelping
                | [<CompiledName("fa-hands-usd")>] HandsUsd
                | [<CompiledName("fa-handshake")>] Handshake
                | [<CompiledName("fa-handshake-alt")>] HandshakeAlt
                | [<CompiledName("fa-hanukiah")>] Hanukiah
                | [<CompiledName("fa-hashtag")>] Hashtag
                | [<CompiledName("fa-hat-witch")>] HatWitch
                | [<CompiledName("fa-hat-wizard")>] HatWizard
                | [<CompiledName("fa-haykal")>] Haykal
                | [<CompiledName("fa-hdd")>] Hdd
                | [<CompiledName("fa-head-side")>] HeadSide
                | [<CompiledName("fa-head-vr")>] HeadVr
                | [<CompiledName("fa-heading")>] Heading
                | [<CompiledName("fa-headphones")>] Headphones
                | [<CompiledName("fa-headphones-alt")>] HeadphonesAlt
                | [<CompiledName("fa-headset")>] Headset
                | [<CompiledName("fa-heart")>] Heart
                | [<CompiledName("fa-heart-circle")>] HeartCircle
                | [<CompiledName("fa-heart-rate")>] HeartRate
                | [<CompiledName("fa-heart-square")>] HeartSquare
                | [<CompiledName("fa-heartbeat")>] Heartbeat
                | [<CompiledName("fa-helicopter")>] Helicopter
                | [<CompiledName("fa-helmet-battle")>] HelmetBattle
                | [<CompiledName("fa-hexagon")>] Hexagon
                | [<CompiledName("fa-highlighter")>] Highlighter
                | [<CompiledName("fa-hiking")>] Hiking
                | [<CompiledName("fa-hippo")>] Hippo
                | [<CompiledName("fa-history")>] History
                | [<CompiledName("fa-hockey-mask")>] HockeyMask
                | [<CompiledName("fa-hockey-puck")>] HockeyPuck
                | [<CompiledName("fa-hockey-sticks")>] HockeySticks
                | [<CompiledName("fa-home")>] Home
                | [<CompiledName("fa-home-heart")>] HomeHeart
                | [<CompiledName("fa-hood-cloak")>] HoodCloak
                | [<CompiledName("fa-horse")>] Horse
                | [<CompiledName("fa-hospital")>] Hospital
                | [<CompiledName("fa-hospital-alt")>] HospitalAlt
                | [<CompiledName("fa-hospital-symbol")>] HospitalSymbol
                | [<CompiledName("fa-hot-tub")>] HotTub
                | [<CompiledName("fa-hotel")>] Hotel
                | [<CompiledName("fa-hourglass")>] Hourglass
                | [<CompiledName("fa-hourglass-end")>] HourglassEnd
                | [<CompiledName("fa-hourglass-half")>] HourglassHalf
                | [<CompiledName("fa-hourglass-start")>] HourglassStart
                | [<CompiledName("fa-house-damage")>] HouseDamage
                | [<CompiledName("fa-hryvnia")>] Hryvnia
                | [<CompiledName("fa-i-cursor")>] ICursor
                | [<CompiledName("fa-id-badge")>] IdBadge
                | [<CompiledName("fa-id-card")>] IdCard
                | [<CompiledName("fa-id-card-alt")>] IdCardAlt
                | [<CompiledName("fa-image")>] Image
                | [<CompiledName("fa-images")>] Images
                | [<CompiledName("fa-inbox")>] Inbox
                | [<CompiledName("fa-inbox-in")>] InboxIn
                | [<CompiledName("fa-inbox-out")>] InboxOut
                | [<CompiledName("fa-indent")>] Indent
                | [<CompiledName("fa-industry")>] Industry
                | [<CompiledName("fa-industry-alt")>] IndustryAlt
                | [<CompiledName("fa-infinity")>] Infinity
                | [<CompiledName("fa-info")>] Info
                | [<CompiledName("fa-info-circle")>] InfoCircle
                | [<CompiledName("fa-info-square")>] InfoSquare
                | [<CompiledName("fa-inhaler")>] Inhaler
                | [<CompiledName("fa-integral")>] Integral
                | [<CompiledName("fa-intersection")>] Intersection
                | [<CompiledName("fa-inventory")>] Inventory
                | [<CompiledName("fa-italic")>] Italic
                | [<CompiledName("fa-jack-o-lantern")>] JackOLantern
                | [<CompiledName("fa-jedi")>] Jedi
                | [<CompiledName("fa-joint")>] Joint
                | [<CompiledName("fa-journal-whills")>] JournalWhills
                | [<CompiledName("fa-kaaba")>] Kaaba
                | [<CompiledName("fa-key")>] Key
                | [<CompiledName("fa-key-skeleton")>] KeySkeleton
                | [<CompiledName("fa-keyboard")>] Keyboard
                | [<CompiledName("fa-keynote")>] Keynote
                | [<CompiledName("fa-khanda")>] Khanda
                | [<CompiledName("fa-kidneys")>] Kidneys
                | [<CompiledName("fa-kiss")>] Kiss
                | [<CompiledName("fa-kiss-beam")>] KissBeam
                | [<CompiledName("fa-kiss-wink-heart")>] KissWinkHeart
                | [<CompiledName("fa-kite")>] Kite
                | [<CompiledName("fa-kiwi-bird")>] KiwiBird
                | [<CompiledName("fa-knife-kitchen")>] KnifeKitchen
                | [<CompiledName("fa-lambda")>] Lambda
                | [<CompiledName("fa-lamp")>] Lamp
                | [<CompiledName("fa-landmark")>] Landmark
                | [<CompiledName("fa-language")>] Language
                | [<CompiledName("fa-laptop")>] Laptop
                | [<CompiledName("fa-laptop-code")>] LaptopCode
                | [<CompiledName("fa-laugh")>] Laugh
                | [<CompiledName("fa-laugh-beam")>] LaughBeam
                | [<CompiledName("fa-laugh-squint")>] LaughSquint
                | [<CompiledName("fa-laugh-wink")>] LaughWink
                | [<CompiledName("fa-layer-group")>] LayerGroup
                | [<CompiledName("fa-layer-minus")>] LayerMinus
                | [<CompiledName("fa-layer-plus")>] LayerPlus
                | [<CompiledName("fa-leaf")>] Leaf
                | [<CompiledName("fa-leaf-heart")>] LeafHeart
                | [<CompiledName("fa-leaf-maple")>] LeafMaple
                | [<CompiledName("fa-leaf-oak")>] LeafOak
                | [<CompiledName("fa-lemon")>] Lemon
                | [<CompiledName("fa-less-than")>] LessThan
                | [<CompiledName("fa-less-than-equal")>] LessThanEqual
                | [<CompiledName("fa-level-down")>] LevelDown
                | [<CompiledName("fa-level-down-alt")>] LevelDownAlt
                | [<CompiledName("fa-level-up")>] LevelUp
                | [<CompiledName("fa-level-up-alt")>] LevelUpAlt
                | [<CompiledName("fa-life-ring")>] LifeRing
                | [<CompiledName("fa-lightbulb")>] Lightbulb
                | [<CompiledName("fa-lightbulb-dollar")>] LightbulbDollar
                | [<CompiledName("fa-lightbulb-exclamation")>] LightbulbExclamation
                | [<CompiledName("fa-lightbulb-on")>] LightbulbOn
                | [<CompiledName("fa-lightbulb-slash")>] LightbulbSlash
                | [<CompiledName("fa-link")>] Link
                | [<CompiledName("fa-lips")>] Lips
                | [<CompiledName("fa-lira-sign")>] LiraSign
                | [<CompiledName("fa-list")>] List
                | [<CompiledName("fa-list-alt")>] ListAlt
                | [<CompiledName("fa-list-ol")>] ListOl
                | [<CompiledName("fa-list-ul")>] ListUl
                | [<CompiledName("fa-location")>] Location
                | [<CompiledName("fa-location-arrow")>] LocationArrow
                | [<CompiledName("fa-location-circle")>] LocationCircle
                | [<CompiledName("fa-location-slash")>] LocationSlash
                | [<CompiledName("fa-lock")>] Lock
                | [<CompiledName("fa-lock-alt")>] LockAlt
                | [<CompiledName("fa-lock-open")>] LockOpen
                | [<CompiledName("fa-lock-open-alt")>] LockOpenAlt
                | [<CompiledName("fa-long-arrow-alt-down")>] LongArrowAltDown
                | [<CompiledName("fa-long-arrow-alt-left")>] LongArrowAltLeft
                | [<CompiledName("fa-long-arrow-alt-right")>] LongArrowAltRight
                | [<CompiledName("fa-long-arrow-alt-up")>] LongArrowAltUp
                | [<CompiledName("fa-long-arrow-down")>] LongArrowDown
                | [<CompiledName("fa-long-arrow-left")>] LongArrowLeft
                | [<CompiledName("fa-long-arrow-right")>] LongArrowRight
                | [<CompiledName("fa-long-arrow-up")>] LongArrowUp
                | [<CompiledName("fa-loveseat")>] Loveseat
                | [<CompiledName("fa-low-vision")>] LowVision
                | [<CompiledName("fa-luchador")>] Luchador
                | [<CompiledName("fa-luggage-cart")>] LuggageCart
                | [<CompiledName("fa-lungs")>] Lungs
                | [<CompiledName("fa-mace")>] Mace
                | [<CompiledName("fa-magic")>] Magic
                | [<CompiledName("fa-magnet")>] Magnet
                | [<CompiledName("fa-mail-bulk")>] MailBulk
                | [<CompiledName("fa-male")>] Male
                | [<CompiledName("fa-mandolin")>] Mandolin
                | [<CompiledName("fa-map")>] Map
                | [<CompiledName("fa-map-marked")>] MapMarked
                | [<CompiledName("fa-map-marked-alt")>] MapMarkedAlt
                | [<CompiledName("fa-map-marker")>] MapMarker
                | [<CompiledName("fa-map-marker-alt")>] MapMarkerAlt
                | [<CompiledName("fa-map-marker-alt-slash")>] MapMarkerAltSlash
                | [<CompiledName("fa-map-marker-check")>] MapMarkerCheck
                | [<CompiledName("fa-map-marker-edit")>] MapMarkerEdit
                | [<CompiledName("fa-map-marker-exclamation")>] MapMarkerExclamation
                | [<CompiledName("fa-map-marker-minus")>] MapMarkerMinus
                | [<CompiledName("fa-map-marker-plus")>] MapMarkerPlus
                | [<CompiledName("fa-map-marker-question")>] MapMarkerQuestion
                | [<CompiledName("fa-map-marker-slash")>] MapMarkerSlash
                | [<CompiledName("fa-map-marker-smile")>] MapMarkerSmile
                | [<CompiledName("fa-map-marker-times")>] MapMarkerTimes
                | [<CompiledName("fa-map-pin")>] MapPin
                | [<CompiledName("fa-map-signs")>] MapSigns
                | [<CompiledName("fa-marker")>] Marker
                | [<CompiledName("fa-mars")>] Mars
                | [<CompiledName("fa-mars-double")>] MarsDouble
                | [<CompiledName("fa-mars-stroke")>] MarsStroke
                | [<CompiledName("fa-mars-stroke-h")>] MarsStrokeH
                | [<CompiledName("fa-mars-stroke-v")>] MarsStrokeV
                | [<CompiledName("fa-mask")>] Mask
                | [<CompiledName("fa-medal")>] Medal
                | [<CompiledName("fa-medkit")>] Medkit
                | [<CompiledName("fa-megaphone")>] Megaphone
                | [<CompiledName("fa-meh")>] Meh
                | [<CompiledName("fa-meh-blank")>] MehBlank
                | [<CompiledName("fa-meh-rolling-eyes")>] MehRollingEyes
                | [<CompiledName("fa-memory")>] Memory
                | [<CompiledName("fa-menorah")>] Menorah
                | [<CompiledName("fa-mercury")>] Mercury
                | [<CompiledName("fa-microchip")>] Microchip
                | [<CompiledName("fa-microphone")>] Microphone
                | [<CompiledName("fa-microphone-alt")>] MicrophoneAlt
                | [<CompiledName("fa-microphone-alt-slash")>] MicrophoneAltSlash
                | [<CompiledName("fa-microphone-slash")>] MicrophoneSlash
                | [<CompiledName("fa-microscope")>] Microscope
                | [<CompiledName("fa-mind-share")>] MindShare
                | [<CompiledName("fa-minus")>] Minus
                | [<CompiledName("fa-minus-circle")>] MinusCircle
                | [<CompiledName("fa-minus-hexagon")>] MinusHexagon
                | [<CompiledName("fa-minus-octagon")>] MinusOctagon
                | [<CompiledName("fa-minus-square")>] MinusSquare
                | [<CompiledName("fa-mobile")>] Mobile
                | [<CompiledName("fa-mobile-alt")>] MobileAlt
                | [<CompiledName("fa-mobile-android")>] MobileAndroid
                | [<CompiledName("fa-mobile-android-alt")>] MobileAndroidAlt
                | [<CompiledName("fa-money-bill")>] MoneyBill
                | [<CompiledName("fa-money-bill-alt")>] MoneyBillAlt
                | [<CompiledName("fa-money-bill-wave")>] MoneyBillWave
                | [<CompiledName("fa-money-bill-wave-alt")>] MoneyBillWaveAlt
                | [<CompiledName("fa-money-check")>] MoneyCheck
                | [<CompiledName("fa-money-check-alt")>] MoneyCheckAlt
                | [<CompiledName("fa-monitor-heart-rate")>] MonitorHeartRate
                | [<CompiledName("fa-monkey")>] Monkey
                | [<CompiledName("fa-monument")>] Monument
                | [<CompiledName("fa-moon")>] Moon
                | [<CompiledName("fa-mortar-pestle")>] MortarPestle
                | [<CompiledName("fa-mosque")>] Mosque
                | [<CompiledName("fa-motorcycle")>] Motorcycle
                | [<CompiledName("fa-mountain")>] Mountain
                | [<CompiledName("fa-mountains")>] Mountains
                | [<CompiledName("fa-mouse-pointer")>] MousePointer
                | [<CompiledName("fa-music")>] Music
                | [<CompiledName("fa-narwhal")>] Narwhal
                | [<CompiledName("fa-network-wired")>] NetworkWired
                | [<CompiledName("fa-neuter")>] Neuter
                | [<CompiledName("fa-newspaper")>] Newspaper
                | [<CompiledName("fa-not-equal")>] NotEqual
                | [<CompiledName("fa-notes-medical")>] NotesMedical
                | [<CompiledName("fa-object-group")>] ObjectGroup
                | [<CompiledName("fa-object-ungroup")>] ObjectUngroup
                | [<CompiledName("fa-octagon")>] Octagon
                | [<CompiledName("fa-oil-can")>] OilCan
                | [<CompiledName("fa-oil-temp")>] OilTemp
                | [<CompiledName("fa-om")>] Om
                | [<CompiledName("fa-omega")>] Omega
                | [<CompiledName("fa-otter")>] Otter
                | [<CompiledName("fa-outdent")>] Outdent
                | [<CompiledName("fa-paint-brush")>] PaintBrush
                | [<CompiledName("fa-paint-brush-alt")>] PaintBrushAlt
                | [<CompiledName("fa-paint-roller")>] PaintRoller
                | [<CompiledName("fa-palette")>] Palette
                | [<CompiledName("fa-pallet")>] Pallet
                | [<CompiledName("fa-pallet-alt")>] PalletAlt
                | [<CompiledName("fa-paper-plane")>] PaperPlane
                | [<CompiledName("fa-paperclip")>] Paperclip
                | [<CompiledName("fa-parachute-box")>] ParachuteBox
                | [<CompiledName("fa-paragraph")>] Paragraph
                | [<CompiledName("fa-parking")>] Parking
                | [<CompiledName("fa-parking-circle")>] ParkingCircle
                | [<CompiledName("fa-parking-circle-slash")>] ParkingCircleSlash
                | [<CompiledName("fa-parking-slash")>] ParkingSlash
                | [<CompiledName("fa-passport")>] Passport
                | [<CompiledName("fa-pastafarianism")>] Pastafarianism
                | [<CompiledName("fa-paste")>] Paste
                | [<CompiledName("fa-pause")>] Pause
                | [<CompiledName("fa-pause-circle")>] PauseCircle
                | [<CompiledName("fa-paw")>] Paw
                | [<CompiledName("fa-paw-alt")>] PawAlt
                | [<CompiledName("fa-paw-claws")>] PawClaws
                | [<CompiledName("fa-peace")>] Peace
                | [<CompiledName("fa-pegasus")>] Pegasus
                | [<CompiledName("fa-pen")>] Pen
                | [<CompiledName("fa-pen-alt")>] PenAlt
                | [<CompiledName("fa-pen-fancy")>] PenFancy
                | [<CompiledName("fa-pen-nib")>] PenNib
                | [<CompiledName("fa-pen-square")>] PenSquare
                | [<CompiledName("fa-pencil")>] Pencil
                | [<CompiledName("fa-pencil-alt")>] PencilAlt
                | [<CompiledName("fa-pencil-paintbrush")>] PencilPaintbrush
                | [<CompiledName("fa-pencil-ruler")>] PencilRuler
                | [<CompiledName("fa-pennant")>] Pennant
                | [<CompiledName("fa-people-carry")>] PeopleCarry
                | [<CompiledName("fa-percent")>] Percent
                | [<CompiledName("fa-percentage")>] Percentage
                | [<CompiledName("fa-person-carry")>] PersonCarry
                | [<CompiledName("fa-person-dolly")>] PersonDolly
                | [<CompiledName("fa-person-dolly-empty")>] PersonDollyEmpty
                | [<CompiledName("fa-phone")>] Phone
                | [<CompiledName("fa-phone-office")>] PhoneOffice
                | [<CompiledName("fa-phone-plus")>] PhonePlus
                | [<CompiledName("fa-phone-slash")>] PhoneSlash
                | [<CompiledName("fa-phone-square")>] PhoneSquare
                | [<CompiledName("fa-phone-volume")>] PhoneVolume
                | [<CompiledName("fa-pi")>] Pi
                | [<CompiledName("fa-pie")>] Pie
                | [<CompiledName("fa-pig")>] Pig
                | [<CompiledName("fa-piggy-bank")>] PiggyBank
                | [<CompiledName("fa-pills")>] Pills
                | [<CompiledName("fa-place-of-worship")>] PlaceOfWorship
                | [<CompiledName("fa-plane")>] Plane
                | [<CompiledName("fa-plane-alt")>] PlaneAlt
                | [<CompiledName("fa-plane-arrival")>] PlaneArrival
                | [<CompiledName("fa-plane-departure")>] PlaneDeparture
                | [<CompiledName("fa-play")>] Play
                | [<CompiledName("fa-play-circle")>] PlayCircle
                | [<CompiledName("fa-plug")>] Plug
                | [<CompiledName("fa-plus")>] Plus
                | [<CompiledName("fa-plus-circle")>] PlusCircle
                | [<CompiledName("fa-plus-hexagon")>] PlusHexagon
                | [<CompiledName("fa-plus-octagon")>] PlusOctagon
                | [<CompiledName("fa-plus-square")>] PlusSquare
                | [<CompiledName("fa-podcast")>] Podcast
                | [<CompiledName("fa-podium")>] Podium
                | [<CompiledName("fa-poll")>] Poll
                | [<CompiledName("fa-poll-h")>] PollH
                | [<CompiledName("fa-poo")>] Poo
                | [<CompiledName("fa-poop")>] Poop
                | [<CompiledName("fa-portrait")>] Portrait
                | [<CompiledName("fa-pound-sign")>] PoundSign
                | [<CompiledName("fa-power-off")>] PowerOff
                | [<CompiledName("fa-pray")>] Pray
                | [<CompiledName("fa-praying-hands")>] PrayingHands
                | [<CompiledName("fa-prescription")>] Prescription
                | [<CompiledName("fa-prescription-bottle")>] PrescriptionBottle
                | [<CompiledName("fa-prescription-bottle-alt")>] PrescriptionBottleAlt
                | [<CompiledName("fa-presentation")>] Presentation
                | [<CompiledName("fa-print")>] Print
                | [<CompiledName("fa-print-slash")>] PrintSlash
                | [<CompiledName("fa-procedures")>] Procedures
                | [<CompiledName("fa-project-diagram")>] ProjectDiagram
                | [<CompiledName("fa-pumpkin")>] Pumpkin
                | [<CompiledName("fa-puzzle-piece")>] PuzzlePiece
                | [<CompiledName("fa-qrcode")>] Qrcode
                | [<CompiledName("fa-question")>] Question
                | [<CompiledName("fa-question-circle")>] QuestionCircle
                | [<CompiledName("fa-question-square")>] QuestionSquare
                | [<CompiledName("fa-quidditch")>] Quidditch
                | [<CompiledName("fa-quote-left")>] QuoteLeft
                | [<CompiledName("fa-quote-right")>] QuoteRight
                | [<CompiledName("fa-quran")>] Quran
                | [<CompiledName("fa-rabbit")>] Rabbit
                | [<CompiledName("fa-rabbit-fast")>] RabbitFast
                | [<CompiledName("fa-racquet")>] Racquet
                | [<CompiledName("fa-ram")>] Ram
                | [<CompiledName("fa-ramp-loading")>] RampLoading
                | [<CompiledName("fa-random")>] Random
                | [<CompiledName("fa-receipt")>] Receipt
                | [<CompiledName("fa-rectangle-landscape")>] RectangleLandscape
                | [<CompiledName("fa-rectangle-portrait")>] RectanglePortrait
                | [<CompiledName("fa-rectangle-wide")>] RectangleWide
                | [<CompiledName("fa-recycle")>] Recycle
                | [<CompiledName("fa-redo")>] Redo
                | [<CompiledName("fa-redo-alt")>] RedoAlt
                | [<CompiledName("fa-registered")>] Registered
                | [<CompiledName("fa-repeat")>] Repeat
                | [<CompiledName("fa-repeat-1")>] Repeat1
                | [<CompiledName("fa-repeat-1-alt")>] Repeat1Alt
                | [<CompiledName("fa-repeat-alt")>] RepeatAlt
                | [<CompiledName("fa-reply")>] Reply
                | [<CompiledName("fa-reply-all")>] ReplyAll
                | [<CompiledName("fa-retweet")>] Retweet
                | [<CompiledName("fa-retweet-alt")>] RetweetAlt
                | [<CompiledName("fa-ribbon")>] Ribbon
                | [<CompiledName("fa-ring")>] Ring
                | [<CompiledName("fa-road")>] Road
                | [<CompiledName("fa-robot")>] Robot
                | [<CompiledName("fa-rocket")>] Rocket
                | [<CompiledName("fa-route")>] Route
                | [<CompiledName("fa-route-highway")>] RouteHighway
                | [<CompiledName("fa-route-interstate")>] RouteInterstate
                | [<CompiledName("fa-rss")>] Rss
                | [<CompiledName("fa-rss-square")>] RssSquare
                | [<CompiledName("fa-ruble-sign")>] RubleSign
                | [<CompiledName("fa-ruler")>] Ruler
                | [<CompiledName("fa-ruler-combined")>] RulerCombined
                | [<CompiledName("fa-ruler-horizontal")>] RulerHorizontal
                | [<CompiledName("fa-ruler-triangle")>] RulerTriangle
                | [<CompiledName("fa-ruler-vertical")>] RulerVertical
                | [<CompiledName("fa-running")>] Running
                | [<CompiledName("fa-rupee-sign")>] RupeeSign
                | [<CompiledName("fa-sad-cry")>] SadCry
                | [<CompiledName("fa-sad-tear")>] SadTear
                | [<CompiledName("fa-save")>] Save
                | [<CompiledName("fa-scalpel")>] Scalpel
                | [<CompiledName("fa-scalpel-path")>] ScalpelPath
                | [<CompiledName("fa-scanner")>] Scanner
                | [<CompiledName("fa-scanner-keyboard")>] ScannerKeyboard
                | [<CompiledName("fa-scanner-touchscreen")>] ScannerTouchscreen
                | [<CompiledName("fa-scarecrow")>] Scarecrow
                | [<CompiledName("fa-school")>] School
                | [<CompiledName("fa-screwdriver")>] Screwdriver
                | [<CompiledName("fa-scroll")>] Scroll
                | [<CompiledName("fa-scroll-old")>] ScrollOld
                | [<CompiledName("fa-scrubber")>] Scrubber
                | [<CompiledName("fa-scythe")>] Scythe
                | [<CompiledName("fa-search")>] Search
                | [<CompiledName("fa-search-dollar")>] SearchDollar
                | [<CompiledName("fa-search-location")>] SearchLocation
                | [<CompiledName("fa-search-minus")>] SearchMinus
                | [<CompiledName("fa-search-plus")>] SearchPlus
                | [<CompiledName("fa-seedling")>] Seedling
                | [<CompiledName("fa-server")>] Server
                | [<CompiledName("fa-shapes")>] Shapes
                | [<CompiledName("fa-share")>] Share
                | [<CompiledName("fa-share-all")>] ShareAll
                | [<CompiledName("fa-share-alt")>] ShareAlt
                | [<CompiledName("fa-share-alt-square")>] ShareAltSquare
                | [<CompiledName("fa-share-square")>] ShareSquare
                | [<CompiledName("fa-sheep")>] Sheep
                | [<CompiledName("fa-shekel-sign")>] ShekelSign
                | [<CompiledName("fa-shield")>] Shield
                | [<CompiledName("fa-shield-alt")>] ShieldAlt
                | [<CompiledName("fa-shield-check")>] ShieldCheck
                | [<CompiledName("fa-shield-cross")>] ShieldCross
                | [<CompiledName("fa-ship")>] Ship
                | [<CompiledName("fa-shipping-fast")>] ShippingFast
                | [<CompiledName("fa-shipping-timed")>] ShippingTimed
                | [<CompiledName("fa-shoe-prints")>] ShoePrints
                | [<CompiledName("fa-shopping-bag")>] ShoppingBag
                | [<CompiledName("fa-shopping-basket")>] ShoppingBasket
                | [<CompiledName("fa-shopping-cart")>] ShoppingCart
                | [<CompiledName("fa-shovel")>] Shovel
                | [<CompiledName("fa-shower")>] Shower
                | [<CompiledName("fa-shredder")>] Shredder
                | [<CompiledName("fa-shuttle-van")>] ShuttleVan
                | [<CompiledName("fa-shuttlecock")>] Shuttlecock
                | [<CompiledName("fa-sigma")>] Sigma
                | [<CompiledName("fa-sign")>] Sign
                | [<CompiledName("fa-sign-in")>] SignIn
                | [<CompiledName("fa-sign-in-alt")>] SignInAlt
                | [<CompiledName("fa-sign-language")>] SignLanguage
                | [<CompiledName("fa-sign-out")>] SignOut
                | [<CompiledName("fa-sign-out-alt")>] SignOutAlt
                | [<CompiledName("fa-signal")>] Signal
                | [<CompiledName("fa-signal-1")>] Signal1
                | [<CompiledName("fa-signal-2")>] Signal2
                | [<CompiledName("fa-signal-3")>] Signal3
                | [<CompiledName("fa-signal-4")>] Signal4
                | [<CompiledName("fa-signal-alt")>] SignalAlt
                | [<CompiledName("fa-signal-alt-1")>] SignalAlt1
                | [<CompiledName("fa-signal-alt-2")>] SignalAlt2
                | [<CompiledName("fa-signal-alt-3")>] SignalAlt3
                | [<CompiledName("fa-signal-alt-slash")>] SignalAltSlash
                | [<CompiledName("fa-signal-slash")>] SignalSlash
                | [<CompiledName("fa-signature")>] Signature
                | [<CompiledName("fa-sitemap")>] Sitemap
                | [<CompiledName("fa-skeleton")>] Skeleton
                | [<CompiledName("fa-skull")>] Skull
                | [<CompiledName("fa-skull-crossbones")>] SkullCrossbones
                | [<CompiledName("fa-slash")>] Slash
                | [<CompiledName("fa-sliders-h")>] SlidersH
                | [<CompiledName("fa-sliders-h-square")>] SlidersHSquare
                | [<CompiledName("fa-sliders-v")>] SlidersV
                | [<CompiledName("fa-sliders-v-square")>] SlidersVSquare
                | [<CompiledName("fa-smile")>] Smile
                | [<CompiledName("fa-smile-beam")>] SmileBeam
                | [<CompiledName("fa-smile-plus")>] SmilePlus
                | [<CompiledName("fa-smile-wink")>] SmileWink
                | [<CompiledName("fa-smoking")>] Smoking
                | [<CompiledName("fa-smoking-ban")>] SmokingBan
                | [<CompiledName("fa-snake")>] Snake
                | [<CompiledName("fa-snowflake")>] Snowflake
                | [<CompiledName("fa-socks")>] Socks
                | [<CompiledName("fa-solar-panel")>] SolarPanel
                | [<CompiledName("fa-sort")>] Sort
                | [<CompiledName("fa-sort-alpha-down")>] SortAlphaDown
                | [<CompiledName("fa-sort-alpha-up")>] SortAlphaUp
                | [<CompiledName("fa-sort-amount-down")>] SortAmountDown
                | [<CompiledName("fa-sort-amount-up")>] SortAmountUp
                | [<CompiledName("fa-sort-down")>] SortDown
                | [<CompiledName("fa-sort-numeric-down")>] SortNumericDown
                | [<CompiledName("fa-sort-numeric-up")>] SortNumericUp
                | [<CompiledName("fa-sort-up")>] SortUp
                | [<CompiledName("fa-spa")>] Spa
                | [<CompiledName("fa-space-shuttle")>] SpaceShuttle
                | [<CompiledName("fa-spade")>] Spade
                | [<CompiledName("fa-spider")>] Spider
                | [<CompiledName("fa-spider-black-widow")>] SpiderBlackWidow
                | [<CompiledName("fa-spider-web")>] SpiderWeb
                | [<CompiledName("fa-spinner")>] Spinner
                | [<CompiledName("fa-spinner-third")>] SpinnerThird
                | [<CompiledName("fa-splotch")>] Splotch
                | [<CompiledName("fa-spray-can")>] SprayCan
                | [<CompiledName("fa-square")>] Square
                | [<CompiledName("fa-square-full")>] SquareFull
                | [<CompiledName("fa-square-root")>] SquareRoot
                | [<CompiledName("fa-square-root-alt")>] SquareRootAlt
                | [<CompiledName("fa-squirrel")>] Squirrel
                | [<CompiledName("fa-staff")>] Staff
                | [<CompiledName("fa-stamp")>] Stamp
                | [<CompiledName("fa-star")>] Star
                | [<CompiledName("fa-star-and-crescent")>] StarAndCrescent
                | [<CompiledName("fa-star-exclamation")>] StarExclamation
                | [<CompiledName("fa-star-half")>] StarHalf
                | [<CompiledName("fa-star-half-alt")>] StarHalfAlt
                | [<CompiledName("fa-star-of-david")>] StarOfDavid
                | [<CompiledName("fa-star-of-life")>] StarOfLife
                | [<CompiledName("fa-steering-wheel")>] SteeringWheel
                | [<CompiledName("fa-step-backward")>] StepBackward
                | [<CompiledName("fa-step-forward")>] StepForward
                | [<CompiledName("fa-stethoscope")>] Stethoscope
                | [<CompiledName("fa-sticky-note")>] StickyNote
                | [<CompiledName("fa-stomach")>] Stomach
                | [<CompiledName("fa-stop")>] Stop
                | [<CompiledName("fa-stop-circle")>] StopCircle
                | [<CompiledName("fa-stopwatch")>] Stopwatch
                | [<CompiledName("fa-store")>] Store
                | [<CompiledName("fa-store-alt")>] StoreAlt
                | [<CompiledName("fa-stream")>] Stream
                | [<CompiledName("fa-street-view")>] StreetView
                | [<CompiledName("fa-strikethrough")>] Strikethrough
                | [<CompiledName("fa-stroopwafel")>] Stroopwafel
                | [<CompiledName("fa-subscript")>] Subscript
                | [<CompiledName("fa-subway")>] Subway
                | [<CompiledName("fa-suitcase")>] Suitcase
                | [<CompiledName("fa-suitcase-rolling")>] SuitcaseRolling
                | [<CompiledName("fa-sun")>] Sun
                | [<CompiledName("fa-superscript")>] Superscript
                | [<CompiledName("fa-surprise")>] Surprise
                | [<CompiledName("fa-swatchbook")>] Swatchbook
                | [<CompiledName("fa-swimmer")>] Swimmer
                | [<CompiledName("fa-swimming-pool")>] SwimmingPool
                | [<CompiledName("fa-sword")>] Sword
                | [<CompiledName("fa-swords")>] Swords
                | [<CompiledName("fa-synagogue")>] Synagogue
                | [<CompiledName("fa-sync")>] Sync
                | [<CompiledName("fa-sync-alt")>] SyncAlt
                | [<CompiledName("fa-syringe")>] Syringe
                | [<CompiledName("fa-table")>] Table
                | [<CompiledName("fa-table-tennis")>] TableTennis
                | [<CompiledName("fa-tablet")>] Tablet
                | [<CompiledName("fa-tablet-alt")>] TabletAlt
                | [<CompiledName("fa-tablet-android")>] TabletAndroid
                | [<CompiledName("fa-tablet-android-alt")>] TabletAndroidAlt
                | [<CompiledName("fa-tablet-rugged")>] TabletRugged
                | [<CompiledName("fa-tablets")>] Tablets
                | [<CompiledName("fa-tachometer")>] Tachometer
                | [<CompiledName("fa-tachometer-alt")>] TachometerAlt
                | [<CompiledName("fa-tachometer-alt-average")>] TachometerAltAverage
                | [<CompiledName("fa-tachometer-alt-fast")>] TachometerAltFast
                | [<CompiledName("fa-tachometer-alt-fastest")>] TachometerAltFastest
                | [<CompiledName("fa-tachometer-alt-slow")>] TachometerAltSlow
                | [<CompiledName("fa-tachometer-alt-slowest")>] TachometerAltSlowest
                | [<CompiledName("fa-tachometer-average")>] TachometerAverage
                | [<CompiledName("fa-tachometer-fast")>] TachometerFast
                | [<CompiledName("fa-tachometer-fastest")>] TachometerFastest
                | [<CompiledName("fa-tachometer-slow")>] TachometerSlow
                | [<CompiledName("fa-tachometer-slowest")>] TachometerSlowest
                | [<CompiledName("fa-tag")>] Tag
                //| [<CompiledName("fa-tags")>] Tags
                | [<CompiledName("fa-tally")>] Tally
                | [<CompiledName("fa-tape")>] Tape
                | [<CompiledName("fa-tasks")>] Tasks
                | [<CompiledName("fa-taxi")>] Taxi
                | [<CompiledName("fa-teeth")>] Teeth
                | [<CompiledName("fa-teeth-open")>] TeethOpen
                | [<CompiledName("fa-tennis-ball")>] TennisBall
                | [<CompiledName("fa-terminal")>] Terminal
                | [<CompiledName("fa-text-height")>] TextHeight
                | [<CompiledName("fa-text-width")>] TextWidth
                | [<CompiledName("fa-th")>] Th
                | [<CompiledName("fa-th-large")>] ThLarge
                | [<CompiledName("fa-th-list")>] ThList
                | [<CompiledName("fa-theater-masks")>] TheaterMasks
                | [<CompiledName("fa-thermometer")>] Thermometer
                | [<CompiledName("fa-thermometer-empty")>] ThermometerEmpty
                | [<CompiledName("fa-thermometer-full")>] ThermometerFull
                | [<CompiledName("fa-thermometer-half")>] ThermometerHalf
                | [<CompiledName("fa-thermometer-quarter")>] ThermometerQuarter
                | [<CompiledName("fa-thermometer-three-quarters")>] ThermometerThreeQuarters
                | [<CompiledName("fa-theta")>] Theta
                | [<CompiledName("fa-thumbs-down")>] ThumbsDown
                | [<CompiledName("fa-thumbs-up")>] ThumbsUp
                | [<CompiledName("fa-thumbtack")>] Thumbtack
                | [<CompiledName("fa-ticket")>] Ticket
                | [<CompiledName("fa-ticket-alt")>] TicketAlt
                | [<CompiledName("fa-tilde")>] Tilde
                | [<CompiledName("fa-times")>] Times
                | [<CompiledName("fa-times-circle")>] TimesCircle
                | [<CompiledName("fa-times-hexagon")>] TimesHexagon
                | [<CompiledName("fa-times-octagon")>] TimesOctagon
                | [<CompiledName("fa-times-square")>] TimesSquare
                | [<CompiledName("fa-tint")>] Tint
                | [<CompiledName("fa-tint-slash")>] TintSlash
                | [<CompiledName("fa-tire")>] Tire
                | [<CompiledName("fa-tire-flat")>] TireFlat
                | [<CompiledName("fa-tire-pressure-warning")>] TirePressureWarning
                | [<CompiledName("fa-tire-rugged")>] TireRugged
                | [<CompiledName("fa-tired")>] Tired
                | [<CompiledName("fa-toggle-off")>] ToggleOff
                | [<CompiledName("fa-toggle-on")>] ToggleOn
                | [<CompiledName("fa-toilet-paper")>] ToiletPaper
                | [<CompiledName("fa-toilet-paper-alt")>] ToiletPaperAlt
                | [<CompiledName("fa-tombstone")>] Tombstone
                | [<CompiledName("fa-tombstone-alt")>] TombstoneAlt
                | [<CompiledName("fa-toolbox")>] Toolbox
                | [<CompiledName("fa-tooth")>] Tooth
                | [<CompiledName("fa-toothbrush")>] Toothbrush
                | [<CompiledName("fa-torah")>] Torah
                | [<CompiledName("fa-torii-gate")>] ToriiGate
                | [<CompiledName("fa-tractor")>] Tractor
                | [<CompiledName("fa-trademark")>] Trademark
                | [<CompiledName("fa-traffic-cone")>] TrafficCone
                | [<CompiledName("fa-traffic-light")>] TrafficLight
                | [<CompiledName("fa-traffic-light-go")>] TrafficLightGo
                | [<CompiledName("fa-traffic-light-slow")>] TrafficLightSlow
                | [<CompiledName("fa-traffic-light-stop")>] TrafficLightStop
                | [<CompiledName("fa-train")>] Train
                | [<CompiledName("fa-transgender")>] Transgender
                | [<CompiledName("fa-transgender-alt")>] TransgenderAlt
                | [<CompiledName("fa-trash")>] Trash
                | [<CompiledName("fa-trash-alt")>] TrashAlt
                | [<CompiledName("fa-treasure-chest")>] TreasureChest
                | [<CompiledName("fa-tree")>] Tree
                | [<CompiledName("fa-tree-alt")>] TreeAlt
                | [<CompiledName("fa-trees")>] Trees
                | [<CompiledName("fa-triangle")>] Triangle
                | [<CompiledName("fa-trophy")>] Trophy
                | [<CompiledName("fa-trophy-alt")>] TrophyAlt
                | [<CompiledName("fa-truck")>] Truck
                | [<CompiledName("fa-truck-container")>] TruckContainer
                | [<CompiledName("fa-truck-couch")>] TruckCouch
                | [<CompiledName("fa-truck-loading")>] TruckLoading
                | [<CompiledName("fa-truck-monster")>] TruckMonster
                | [<CompiledName("fa-truck-moving")>] TruckMoving
                | [<CompiledName("fa-truck-pickup")>] TruckPickup
                | [<CompiledName("fa-truck-ramp")>] TruckRamp
                | [<CompiledName("fa-tshirt")>] Tshirt
                | [<CompiledName("fa-tty")>] Tty
                | [<CompiledName("fa-turkey")>] Turkey
                | [<CompiledName("fa-turtle")>] Turtle
                | [<CompiledName("fa-tv")>] Tv
                | [<CompiledName("fa-tv-retro")>] TvRetro
                | [<CompiledName("fa-umbrella")>] Umbrella
                | [<CompiledName("fa-umbrella-beach")>] UmbrellaBeach
                | [<CompiledName("fa-underline")>] Underline
                | [<CompiledName("fa-undo")>] Undo
                | [<CompiledName("fa-undo-alt")>] UndoAlt
                | [<CompiledName("fa-unicorn")>] Unicorn
                | [<CompiledName("fa-union")>] Union
                | [<CompiledName("fa-universal-access")>] UniversalAccess
                | [<CompiledName("fa-university")>] University
                | [<CompiledName("fa-unlink")>] Unlink
                | [<CompiledName("fa-unlock")>] Unlock
                | [<CompiledName("fa-unlock-alt")>] UnlockAlt
                | [<CompiledName("fa-upload")>] Upload
                | [<CompiledName("fa-usd-circle")>] UsdCircle
                | [<CompiledName("fa-usd-square")>] UsdSquare
                | [<CompiledName("fa-user")>] User
                | [<CompiledName("fa-user-alt")>] UserAlt
                | [<CompiledName("fa-user-alt-slash")>] UserAltSlash
                | [<CompiledName("fa-user-astronaut")>] UserAstronaut
                | [<CompiledName("fa-user-chart")>] UserChart
                | [<CompiledName("fa-user-check")>] UserCheck
                | [<CompiledName("fa-user-circle")>] UserCircle
                | [<CompiledName("fa-user-clock")>] UserClock
                | [<CompiledName("fa-user-cog")>] UserCog
                | [<CompiledName("fa-user-crown")>] UserCrown
                | [<CompiledName("fa-user-edit")>] UserEdit
                | [<CompiledName("fa-user-friends")>] UserFriends
                | [<CompiledName("fa-user-graduate")>] UserGraduate
                | [<CompiledName("fa-user-injured")>] UserInjured
                | [<CompiledName("fa-user-lock")>] UserLock
                | [<CompiledName("fa-user-md")>] UserMd
                | [<CompiledName("fa-user-minus")>] UserMinus
                | [<CompiledName("fa-user-ninja")>] UserNinja
                | [<CompiledName("fa-user-plus")>] UserPlus
                | [<CompiledName("fa-user-secret")>] UserSecret
                | [<CompiledName("fa-user-shield")>] UserShield
                | [<CompiledName("fa-user-slash")>] UserSlash
                | [<CompiledName("fa-user-tag")>] UserTag
                | [<CompiledName("fa-user-tie")>] UserTie
                | [<CompiledName("fa-user-times")>] UserTimes
                | [<CompiledName("fa-users")>] Users
                | [<CompiledName("fa-users-class")>] UsersClass
                | [<CompiledName("fa-users-cog")>] UsersCog
                | [<CompiledName("fa-users-crown")>] UsersCrown
                | [<CompiledName("fa-utensil-fork")>] UtensilFork
                | [<CompiledName("fa-utensil-knife")>] UtensilKnife
                | [<CompiledName("fa-utensil-spoon")>] UtensilSpoon
                | [<CompiledName("fa-utensils")>] Utensils
                | [<CompiledName("fa-utensils-alt")>] UtensilsAlt
                | [<CompiledName("fa-value-absolute")>] ValueAbsolute
                | [<CompiledName("fa-vector-square")>] VectorSquare
                | [<CompiledName("fa-venus")>] Venus
                | [<CompiledName("fa-venus-double")>] VenusDouble
                | [<CompiledName("fa-venus-mars")>] VenusMars
                | [<CompiledName("fa-vial")>] Vial
                | [<CompiledName("fa-vials")>] Vials
                | [<CompiledName("fa-video")>] Video
                | [<CompiledName("fa-video-plus")>] VideoPlus
                | [<CompiledName("fa-video-slash")>] VideoSlash
                | [<CompiledName("fa-vihara")>] Vihara
                | [<CompiledName("fa-volleyball-ball")>] VolleyballBall
                | [<CompiledName("fa-volume")>] Volume
                | [<CompiledName("fa-volume-down")>] VolumeDown
                | [<CompiledName("fa-volume-mute")>] VolumeMute
                | [<CompiledName("fa-volume-off")>] VolumeOff
                | [<CompiledName("fa-volume-slash")>] VolumeSlash
                | [<CompiledName("fa-volume-up")>] VolumeUp
                | [<CompiledName("fa-vr-cardboard")>] VrCardboard
                | [<CompiledName("fa-walking")>] Walking
                | [<CompiledName("fa-wallet")>] Wallet
                | [<CompiledName("fa-wand")>] Wand
                | [<CompiledName("fa-wand-magic")>] WandMagic
                | [<CompiledName("fa-warehouse")>] Warehouse
                | [<CompiledName("fa-warehouse-alt")>] WarehouseAlt
                | [<CompiledName("fa-watch")>] Watch
                | [<CompiledName("fa-watch-fitness")>] WatchFitness
                | [<CompiledName("fa-weight")>] Weight
                | [<CompiledName("fa-weight-hanging")>] WeightHanging
                | [<CompiledName("fa-whale")>] Whale
                | [<CompiledName("fa-wheat")>] Wheat
                | [<CompiledName("fa-wheelchair")>] Wheelchair
                | [<CompiledName("fa-whistle")>] Whistle
                | [<CompiledName("fa-wifi")>] Wifi
                | [<CompiledName("fa-wifi-1")>] Wifi1
                | [<CompiledName("fa-wifi-2")>] Wifi2
                | [<CompiledName("fa-wifi-slash")>] WifiSlash
                | [<CompiledName("fa-wind")>] Wind
                | [<CompiledName("fa-window")>] Window
                | [<CompiledName("fa-window-alt")>] WindowAlt
                | [<CompiledName("fa-window-close")>] WindowClose
                | [<CompiledName("fa-window-maximize")>] WindowMaximize
                | [<CompiledName("fa-window-minimize")>] WindowMinimize
                | [<CompiledName("fa-window-restore")>] WindowRestore
                | [<CompiledName("fa-wine-bottle")>] WineBottle
                | [<CompiledName("fa-wine-glass")>] WineGlass
                | [<CompiledName("fa-wine-glass-alt")>] WineGlassAlt
                | [<CompiledName("fa-won-sign")>] WonSign
                | [<CompiledName("fa-wrench")>] Wrench
                | [<CompiledName("fa-x-ray")>] XRay
                | [<CompiledName("fa-yen-sign")>] YenSign
                | [<CompiledName("fa-yin-yang")>] YinYang
                interface  IFontAwesomeIcon

            let inline Tags<'T> = unbox<IFontAwesomeIcon> "fa-tags"

        module B =

            [<StringEnum>]
            type FontAwesomeBrands =
                //| [<CompiledName("fa-500px")>] 500px
                | [<CompiledName("fa-accessible-icon")>] AccessibleIcon
                | [<CompiledName("fa-accusoft")>] Accusoft
                | [<CompiledName("fa-acquisitions-incorporated")>] AcquisitionsIncorporated
                | [<CompiledName("fa-adn")>] Adn
                | [<CompiledName("fa-adversal")>] Adversal
                | [<CompiledName("fa-affiliatetheme")>] Affiliatetheme
                | [<CompiledName("fa-algolia")>] Algolia
                | [<CompiledName("fa-alipay")>] Alipay
                | [<CompiledName("fa-amazon")>] Amazon
                | [<CompiledName("fa-amazon-pay")>] AmazonPay
                | [<CompiledName("fa-amilia")>] Amilia
                | [<CompiledName("fa-android")>] Android
                | [<CompiledName("fa-angellist")>] Angellist
                | [<CompiledName("fa-angrycreative")>] Angrycreative
                | [<CompiledName("fa-angular")>] Angular
                | [<CompiledName("fa-app-store")>] AppStore
                | [<CompiledName("fa-app-store-ios")>] AppStoreIos
                | [<CompiledName("fa-apper")>] Apper
                | [<CompiledName("fa-apple")>] Apple
                | [<CompiledName("fa-apple-pay")>] ApplePay
                | [<CompiledName("fa-asymmetrik")>] Asymmetrik
                | [<CompiledName("fa-audible")>] Audible
                | [<CompiledName("fa-autoprefixer")>] Autoprefixer
                | [<CompiledName("fa-avianex")>] Avianex
                | [<CompiledName("fa-aviato")>] Aviato
                | [<CompiledName("fa-aws")>] Aws
                | [<CompiledName("fa-bandcamp")>] Bandcamp
                | [<CompiledName("fa-behance")>] Behance
                | [<CompiledName("fa-behance-square")>] BehanceSquare
                | [<CompiledName("fa-bimobject")>] Bimobject
                | [<CompiledName("fa-bitbucket")>] Bitbucket
                | [<CompiledName("fa-bitcoin")>] Bitcoin
                | [<CompiledName("fa-bity")>] Bity
                | [<CompiledName("fa-black-tie")>] BlackTie
                | [<CompiledName("fa-blackberry")>] Blackberry
                | [<CompiledName("fa-blogger")>] Blogger
                | [<CompiledName("fa-blogger-b")>] BloggerB
                | [<CompiledName("fa-bluetooth")>] Bluetooth
                | [<CompiledName("fa-bluetooth-b")>] BluetoothB
                | [<CompiledName("fa-btc")>] Btc
                | [<CompiledName("fa-buromobelexperte")>] Buromobelexperte
                | [<CompiledName("fa-buysellads")>] Buysellads
                | [<CompiledName("fa-cc-amazon-pay")>] CcAmazonPay
                | [<CompiledName("fa-cc-amex")>] CcAmex
                | [<CompiledName("fa-cc-apple-pay")>] CcApplePay
                | [<CompiledName("fa-cc-diners-club")>] CcDinersClub
                | [<CompiledName("fa-cc-discover")>] CcDiscover
                | [<CompiledName("fa-cc-jcb")>] CcJcb
                | [<CompiledName("fa-cc-mastercard")>] CcMastercard
                | [<CompiledName("fa-cc-paypal")>] CcPaypal
                | [<CompiledName("fa-cc-stripe")>] CcStripe
                | [<CompiledName("fa-cc-visa")>] CcVisa
                | [<CompiledName("fa-centercode")>] Centercode
                | [<CompiledName("fa-chrome")>] Chrome
                | [<CompiledName("fa-cloudscale")>] Cloudscale
                | [<CompiledName("fa-cloudsmith")>] Cloudsmith
                | [<CompiledName("fa-cloudversify")>] Cloudversify
                | [<CompiledName("fa-codepen")>] Codepen
                | [<CompiledName("fa-codiepie")>] Codiepie
                | [<CompiledName("fa-connectdevelop")>] Connectdevelop
                | [<CompiledName("fa-contao")>] Contao
                | [<CompiledName("fa-cpanel")>] Cpanel
                | [<CompiledName("fa-creative-commons")>] CreativeCommons
                | [<CompiledName("fa-creative-commons-by")>] CreativeCommonsBy
                | [<CompiledName("fa-creative-commons-nc")>] CreativeCommonsNc
                | [<CompiledName("fa-creative-commons-nc-eu")>] CreativeCommonsNcEu
                | [<CompiledName("fa-creative-commons-nc-jp")>] CreativeCommonsNcJp
                | [<CompiledName("fa-creative-commons-nd")>] CreativeCommonsNd
                | [<CompiledName("fa-creative-commons-pd")>] CreativeCommonsPd
                | [<CompiledName("fa-creative-commons-pd-alt")>] CreativeCommonsPdAlt
                | [<CompiledName("fa-creative-commons-remix")>] CreativeCommonsRemix
                | [<CompiledName("fa-creative-commons-sa")>] CreativeCommonsSa
                | [<CompiledName("fa-creative-commons-sampling")>] CreativeCommonsSampling
                | [<CompiledName("fa-creative-commons-sampling-plus")>] CreativeCommonsSamplingPlus
                | [<CompiledName("fa-creative-commons-share")>] CreativeCommonsShare
                | [<CompiledName("fa-creative-commons-zero")>] CreativeCommonsZero
                | [<CompiledName("fa-critical-role")>] CriticalRole
                | [<CompiledName("fa-css3")>] Css3
                | [<CompiledName("fa-css3-alt")>] Css3Alt
                | [<CompiledName("fa-cuttlefish")>] Cuttlefish
                | [<CompiledName("fa-d-and-d")>] DAndD
                | [<CompiledName("fa-d-and-d-beyond")>] DAndDBeyond
                | [<CompiledName("fa-dashcube")>] Dashcube
                | [<CompiledName("fa-delicious")>] Delicious
                | [<CompiledName("fa-deploydog")>] Deploydog
                | [<CompiledName("fa-deskpro")>] Deskpro
                | [<CompiledName("fa-dev")>] Dev
                | [<CompiledName("fa-deviantart")>] Deviantart
                | [<CompiledName("fa-digg")>] Digg
                | [<CompiledName("fa-digital-ocean")>] DigitalOcean
                | [<CompiledName("fa-discord")>] Discord
                | [<CompiledName("fa-discourse")>] Discourse
                | [<CompiledName("fa-dochub")>] Dochub
                | [<CompiledName("fa-docker")>] Docker
                | [<CompiledName("fa-draft2digital")>] Draft2digital
                | [<CompiledName("fa-dribbble")>] Dribbble
                | [<CompiledName("fa-dribbble-square")>] DribbbleSquare
                | [<CompiledName("fa-dropbox")>] Dropbox
                | [<CompiledName("fa-drupal")>] Drupal
                | [<CompiledName("fa-dyalog")>] Dyalog
                | [<CompiledName("fa-earlybirds")>] Earlybirds
                | [<CompiledName("fa-ebay")>] Ebay
                | [<CompiledName("fa-edge")>] Edge
                | [<CompiledName("fa-elementor")>] Elementor
                | [<CompiledName("fa-ello")>] Ello
                | [<CompiledName("fa-ember")>] Ember
                | [<CompiledName("fa-empire")>] Empire
                | [<CompiledName("fa-envira")>] Envira
                | [<CompiledName("fa-erlang")>] Erlang
                | [<CompiledName("fa-ethereum")>] Ethereum
                | [<CompiledName("fa-etsy")>] Etsy
                | [<CompiledName("fa-expeditedssl")>] Expeditedssl
                | [<CompiledName("fa-facebook")>] Facebook
                | [<CompiledName("fa-facebook-f")>] FacebookF
                | [<CompiledName("fa-facebook-messenger")>] FacebookMessenger
                | [<CompiledName("fa-facebook-square")>] FacebookSquare
                | [<CompiledName("fa-fantasy-flight-games")>] FantasyFlightGames
                | [<CompiledName("fa-firefox")>] Firefox
                | [<CompiledName("fa-first-order")>] FirstOrder
                | [<CompiledName("fa-first-order-alt")>] FirstOrderAlt
                | [<CompiledName("fa-firstdraft")>] Firstdraft
                | [<CompiledName("fa-flickr")>] Flickr
                | [<CompiledName("fa-flipboard")>] Flipboard
                | [<CompiledName("fa-fly")>] Fly
                | [<CompiledName("fa-font-awesome")>] FontAwesome
                | [<CompiledName("fa-font-awesome-alt")>] FontAwesomeAlt
                | [<CompiledName("fa-font-awesome-flag")>] FontAwesomeFlag
                | [<CompiledName("fa-font-awesome-logo-full")>] FontAwesomeLogoFull
                | [<CompiledName("fa-fonticons")>] Fonticons
                | [<CompiledName("fa-fonticons-fi")>] FonticonsFi
                | [<CompiledName("fa-fort-awesome")>] FortAwesome
                | [<CompiledName("fa-fort-awesome-alt")>] FortAwesomeAlt
                | [<CompiledName("fa-forumbee")>] Forumbee
                | [<CompiledName("fa-foursquare")>] Foursquare
                | [<CompiledName("fa-free-code-camp")>] FreeCodeCamp
                | [<CompiledName("fa-freebsd")>] Freebsd
                | [<CompiledName("fa-fulcrum")>] Fulcrum
                | [<CompiledName("fa-galactic-republic")>] GalacticRepublic
                | [<CompiledName("fa-galactic-senate")>] GalacticSenate
                | [<CompiledName("fa-get-pocket")>] GetPocket
                | [<CompiledName("fa-gg")>] Gg
                | [<CompiledName("fa-gg-circle")>] GgCircle
                | [<CompiledName("fa-git")>] Git
                | [<CompiledName("fa-git-square")>] GitSquare
                | [<CompiledName("fa-github")>] Github
                | [<CompiledName("fa-github-alt")>] GithubAlt
                | [<CompiledName("fa-github-square")>] GithubSquare
                | [<CompiledName("fa-gitkraken")>] Gitkraken
                | [<CompiledName("fa-gitlab")>] Gitlab
                | [<CompiledName("fa-gitter")>] Gitter
                | [<CompiledName("fa-glide")>] Glide
                | [<CompiledName("fa-glide-g")>] GlideG
                | [<CompiledName("fa-gofore")>] Gofore
                | [<CompiledName("fa-goodreads")>] Goodreads
                | [<CompiledName("fa-goodreads-g")>] GoodreadsG
                | [<CompiledName("fa-google")>] Google
                | [<CompiledName("fa-google-drive")>] GoogleDrive
                | [<CompiledName("fa-google-play")>] GooglePlay
                | [<CompiledName("fa-google-plus")>] GooglePlus
                | [<CompiledName("fa-google-plus-g")>] GooglePlusG
                | [<CompiledName("fa-google-plus-square")>] GooglePlusSquare
                | [<CompiledName("fa-google-wallet")>] GoogleWallet
                | [<CompiledName("fa-gratipay")>] Gratipay
                | [<CompiledName("fa-grav")>] Grav
                | [<CompiledName("fa-gripfire")>] Gripfire
                | [<CompiledName("fa-grunt")>] Grunt
                | [<CompiledName("fa-gulp")>] Gulp
                | [<CompiledName("fa-hacker-news")>] HackerNews
                | [<CompiledName("fa-hacker-news-square")>] HackerNewsSquare
                | [<CompiledName("fa-hackerrank")>] Hackerrank
                | [<CompiledName("fa-hips")>] Hips
                | [<CompiledName("fa-hire-a-helper")>] HireAHelper
                | [<CompiledName("fa-hooli")>] Hooli
                | [<CompiledName("fa-hornbill")>] Hornbill
                | [<CompiledName("fa-hotjar")>] Hotjar
                | [<CompiledName("fa-houzz")>] Houzz
                | [<CompiledName("fa-html5")>] Html5
                | [<CompiledName("fa-hubspot")>] Hubspot
                | [<CompiledName("fa-imdb")>] Imdb
                | [<CompiledName("fa-instagram")>] Instagram
                | [<CompiledName("fa-internet-explorer")>] InternetExplorer
                | [<CompiledName("fa-ioxhost")>] Ioxhost
                | [<CompiledName("fa-itunes")>] Itunes
                | [<CompiledName("fa-itunes-note")>] ItunesNote
                | [<CompiledName("fa-java")>] Java
                | [<CompiledName("fa-jedi-order")>] JediOrder
                | [<CompiledName("fa-jenkins")>] Jenkins
                | [<CompiledName("fa-joget")>] Joget
                | [<CompiledName("fa-joomla")>] Joomla
                | [<CompiledName("fa-js")>] Js
                | [<CompiledName("fa-js-square")>] JsSquare
                | [<CompiledName("fa-jsfiddle")>] Jsfiddle
                | [<CompiledName("fa-kaggle")>] Kaggle
                | [<CompiledName("fa-keybase")>] Keybase
                | [<CompiledName("fa-keycdn")>] Keycdn
                | [<CompiledName("fa-kickstarter")>] Kickstarter
                | [<CompiledName("fa-kickstarter-k")>] KickstarterK
                | [<CompiledName("fa-korvue")>] Korvue
                | [<CompiledName("fa-laravel")>] Laravel
                | [<CompiledName("fa-lastfm")>] Lastfm
                | [<CompiledName("fa-lastfm-square")>] LastfmSquare
                | [<CompiledName("fa-leanpub")>] Leanpub
                | [<CompiledName("fa-less")>] Less
                | [<CompiledName("fa-line")>] Line
                | [<CompiledName("fa-linkedin")>] Linkedin
                | [<CompiledName("fa-linkedin-in")>] LinkedinIn
                | [<CompiledName("fa-linode")>] Linode
                | [<CompiledName("fa-linux")>] Linux
                | [<CompiledName("fa-lyft")>] Lyft
                | [<CompiledName("fa-magento")>] Magento
                | [<CompiledName("fa-mailchimp")>] Mailchimp
                | [<CompiledName("fa-mandalorian")>] Mandalorian
                | [<CompiledName("fa-markdown")>] Markdown
                | [<CompiledName("fa-mastodon")>] Mastodon
                | [<CompiledName("fa-maxcdn")>] Maxcdn
                | [<CompiledName("fa-medapps")>] Medapps
                | [<CompiledName("fa-medium")>] Medium
                | [<CompiledName("fa-medium-m")>] MediumM
                | [<CompiledName("fa-medrt")>] Medrt
                | [<CompiledName("fa-meetup")>] Meetup
                | [<CompiledName("fa-megaport")>] Megaport
                | [<CompiledName("fa-microsoft")>] Microsoft
                | [<CompiledName("fa-mix")>] Mix
                | [<CompiledName("fa-mixcloud")>] Mixcloud
                | [<CompiledName("fa-mizuni")>] Mizuni
                | [<CompiledName("fa-modx")>] Modx
                | [<CompiledName("fa-monero")>] Monero
                | [<CompiledName("fa-napster")>] Napster
                | [<CompiledName("fa-neos")>] Neos
                | [<CompiledName("fa-nimblr")>] Nimblr
                | [<CompiledName("fa-nintendo-switch")>] NintendoSwitch
                | [<CompiledName("fa-node")>] Node
                | [<CompiledName("fa-node-js")>] NodeJs
                | [<CompiledName("fa-npm")>] Npm
                | [<CompiledName("fa-ns8")>] Ns8
                | [<CompiledName("fa-nutritionix")>] Nutritionix
                | [<CompiledName("fa-odnoklassniki")>] Odnoklassniki
                | [<CompiledName("fa-odnoklassniki-square")>] OdnoklassnikiSquare
                | [<CompiledName("fa-old-republic")>] OldRepublic
                | [<CompiledName("fa-opencart")>] Opencart
                | [<CompiledName("fa-openid")>] Openid
                | [<CompiledName("fa-opera")>] Opera
                | [<CompiledName("fa-optin-monster")>] OptinMonster
                | [<CompiledName("fa-osi")>] Osi
                | [<CompiledName("fa-page4")>] Page4
                | [<CompiledName("fa-pagelines")>] Pagelines
                | [<CompiledName("fa-palfed")>] Palfed
                | [<CompiledName("fa-patreon")>] Patreon
                | [<CompiledName("fa-paypal")>] Paypal
                | [<CompiledName("fa-penny-arcade")>] PennyArcade
                | [<CompiledName("fa-periscope")>] Periscope
                | [<CompiledName("fa-phabricator")>] Phabricator
                | [<CompiledName("fa-phoenix-framework")>] PhoenixFramework
                | [<CompiledName("fa-phoenix-squadron")>] PhoenixSquadron
                | [<CompiledName("fa-php")>] Php
                | [<CompiledName("fa-pied-piper")>] PiedPiper
                | [<CompiledName("fa-pied-piper-alt")>] PiedPiperAlt
                | [<CompiledName("fa-pied-piper-hat")>] PiedPiperHat
                | [<CompiledName("fa-pied-piper-pp")>] PiedPiperPp
                | [<CompiledName("fa-pinterest")>] Pinterest
                | [<CompiledName("fa-pinterest-p")>] PinterestP
                | [<CompiledName("fa-pinterest-square")>] PinterestSquare
                | [<CompiledName("fa-playstation")>] Playstation
                | [<CompiledName("fa-product-hunt")>] ProductHunt
                | [<CompiledName("fa-pushed")>] Pushed
                | [<CompiledName("fa-python")>] Python
                | [<CompiledName("fa-qq")>] Qq
                | [<CompiledName("fa-quinscape")>] Quinscape
                | [<CompiledName("fa-quora")>] Quora
                | [<CompiledName("fa-r-project")>] RProject
                | [<CompiledName("fa-ravelry")>] Ravelry
                | [<CompiledName("fa-react")>] React
                | [<CompiledName("fa-readme")>] Readme
                | [<CompiledName("fa-rebel")>] Rebel
                | [<CompiledName("fa-red-river")>] RedRiver
                | [<CompiledName("fa-reddit")>] Reddit
                | [<CompiledName("fa-reddit-alien")>] RedditAlien
                | [<CompiledName("fa-reddit-square")>] RedditSquare
                | [<CompiledName("fa-renren")>] Renren
                | [<CompiledName("fa-replyd")>] Replyd
                | [<CompiledName("fa-researchgate")>] Researchgate
                | [<CompiledName("fa-resolving")>] Resolving
                | [<CompiledName("fa-rev")>] Rev
                | [<CompiledName("fa-rocketchat")>] Rocketchat
                | [<CompiledName("fa-rockrms")>] Rockrms
                | [<CompiledName("fa-safari")>] Safari
                | [<CompiledName("fa-sass")>] Sass
                | [<CompiledName("fa-schlix")>] Schlix
                | [<CompiledName("fa-scribd")>] Scribd
                | [<CompiledName("fa-searchengin")>] Searchengin
                | [<CompiledName("fa-sellcast")>] Sellcast
                | [<CompiledName("fa-sellsy")>] Sellsy
                | [<CompiledName("fa-servicestack")>] Servicestack
                | [<CompiledName("fa-shirtsinbulk")>] Shirtsinbulk
                | [<CompiledName("fa-shopware")>] Shopware
                | [<CompiledName("fa-simplybuilt")>] Simplybuilt
                | [<CompiledName("fa-sistrix")>] Sistrix
                | [<CompiledName("fa-sith")>] Sith
                | [<CompiledName("fa-skyatlas")>] Skyatlas
                | [<CompiledName("fa-skype")>] Skype
                | [<CompiledName("fa-slack")>] Slack
                | [<CompiledName("fa-slack-hash")>] SlackHash
                | [<CompiledName("fa-slideshare")>] Slideshare
                | [<CompiledName("fa-snapchat")>] Snapchat
                | [<CompiledName("fa-snapchat-ghost")>] SnapchatGhost
                | [<CompiledName("fa-snapchat-square")>] SnapchatSquare
                | [<CompiledName("fa-soundcloud")>] Soundcloud
                | [<CompiledName("fa-speakap")>] Speakap
                | [<CompiledName("fa-spotify")>] Spotify
                | [<CompiledName("fa-squarespace")>] Squarespace
                | [<CompiledName("fa-stack-exchange")>] StackExchange
                | [<CompiledName("fa-stack-overflow")>] StackOverflow
                | [<CompiledName("fa-staylinked")>] Staylinked
                | [<CompiledName("fa-steam")>] Steam
                | [<CompiledName("fa-steam-square")>] SteamSquare
                | [<CompiledName("fa-steam-symbol")>] SteamSymbol
                | [<CompiledName("fa-sticker-mule")>] StickerMule
                | [<CompiledName("fa-strava")>] Strava
                | [<CompiledName("fa-stripe")>] Stripe
                | [<CompiledName("fa-stripe-s")>] StripeS
                | [<CompiledName("fa-studiovinari")>] Studiovinari
                | [<CompiledName("fa-stumbleupon")>] Stumbleupon
                | [<CompiledName("fa-stumbleupon-circle")>] StumbleuponCircle
                | [<CompiledName("fa-superpowers")>] Superpowers
                | [<CompiledName("fa-supple")>] Supple
                | [<CompiledName("fa-teamspeak")>] Teamspeak
                | [<CompiledName("fa-telegram")>] Telegram
                | [<CompiledName("fa-telegram-plane")>] TelegramPlane
                | [<CompiledName("fa-tencent-weibo")>] TencentWeibo
                | [<CompiledName("fa-the-red-yeti")>] TheRedYeti
                | [<CompiledName("fa-themeco")>] Themeco
                | [<CompiledName("fa-themeisle")>] Themeisle
                | [<CompiledName("fa-think-peaks")>] ThinkPeaks
                | [<CompiledName("fa-trade-federation")>] TradeFederation
                | [<CompiledName("fa-trello")>] Trello
                | [<CompiledName("fa-tripadvisor")>] Tripadvisor
                | [<CompiledName("fa-tumblr")>] Tumblr
                | [<CompiledName("fa-tumblr-square")>] TumblrSquare
                | [<CompiledName("fa-twitch")>] Twitch
                | [<CompiledName("fa-twitter")>] Twitter
                | [<CompiledName("fa-twitter-square")>] TwitterSquare
                | [<CompiledName("fa-typo3")>] Typo3
                | [<CompiledName("fa-uber")>] Uber
                | [<CompiledName("fa-uikit")>] Uikit
                | [<CompiledName("fa-uniregistry")>] Uniregistry
                | [<CompiledName("fa-untappd")>] Untappd
                | [<CompiledName("fa-usb")>] Usb
                | [<CompiledName("fa-ussunnah")>] Ussunnah
                | [<CompiledName("fa-vaadin")>] Vaadin
                | [<CompiledName("fa-viacoin")>] Viacoin
                | [<CompiledName("fa-viadeo")>] Viadeo
                | [<CompiledName("fa-viadeo-square")>] ViadeoSquare
                | [<CompiledName("fa-viber")>] Viber
                | [<CompiledName("fa-vimeo")>] Vimeo
                | [<CompiledName("fa-vimeo-square")>] VimeoSquare
                | [<CompiledName("fa-vimeo-v")>] VimeoV
                | [<CompiledName("fa-vine")>] Vine
                | [<CompiledName("fa-vk")>] Vk
                | [<CompiledName("fa-vnv")>] Vnv
                | [<CompiledName("fa-vuejs")>] Vuejs
                | [<CompiledName("fa-weebly")>] Weebly
                | [<CompiledName("fa-weibo")>] Weibo
                | [<CompiledName("fa-weixin")>] Weixin
                | [<CompiledName("fa-whatsapp")>] Whatsapp
                | [<CompiledName("fa-whatsapp-square")>] WhatsappSquare
                | [<CompiledName("fa-whmcs")>] Whmcs
                | [<CompiledName("fa-wikipedia-w")>] WikipediaW
                | [<CompiledName("fa-windows")>] Windows
                | [<CompiledName("fa-wix")>] Wix
                | [<CompiledName("fa-wizards-of-the-coast")>] WizardsOfTheCoast
                | [<CompiledName("fa-wolf-pack-battalion")>] WolfPackBattalion
                | [<CompiledName("fa-wordpress")>] Wordpress
                | [<CompiledName("fa-wordpress-simple")>] WordpressSimple
                | [<CompiledName("fa-wpbeginner")>] Wpbeginner
                | [<CompiledName("fa-wpexplorer")>] Wpexplorer
                | [<CompiledName("fa-wpforms")>] Wpforms
                | [<CompiledName("fa-wpressr")>] Wpressr
                | [<CompiledName("fa-xbox")>] Xbox
                | [<CompiledName("fa-xing")>] Xing
                | [<CompiledName("fa-xing-square")>] XingSquare
                | [<CompiledName("fa-y-combinator")>] YCombinator
                | [<CompiledName("fa-yahoo")>] Yahoo
                | [<CompiledName("fa-yandex")>] Yandex
                | [<CompiledName("fa-yandex-international")>] YandexInternational
                | [<CompiledName("fa-yelp")>] Yelp
                | [<CompiledName("fa-yoast")>] Yoast
                | [<CompiledName("fa-youtube")>] Youtube
                | [<CompiledName("fa-youtube-square")>] YoutubeSquare
                | [<CompiledName("fa-zhihu")>] Zhihu
                interface  IFontAwesomeIcon

            let inline ``500px``<'T> = unbox<IFontAwesomeIcon> "fa-500px"

            let inline Custom (iconClass: string) = unbox<IFontAwesomeIcon> iconClass

        module Classes =
            module IconSizes =
                let [<Literal>] FaSmall = "fa-xs"
                let [<Literal>] FaMedium = "fa-md"
                let [<Literal>] FaLarge = "fa-lg"
                let [<Literal>] Fa2x = "fa-2x"
                let [<Literal>] Fa3x = "fa-3x"
                let [<Literal>] Fa4x = "fa-4x"
                let [<Literal>] Fa5x = "fa-5x"
                let [<Literal>] Fa7x = "fa-7x"
                let [<Literal>] Fa10x = "fa-10x"
                let [<Literal>] Fw = "fa-fw"

            module Rotations =
                let [<Literal>] Rotate90 = "fa-rotate-90"
                let [<Literal>] Rotate180 = "fa-rotate-180"
                let [<Literal>] Rotate270 = "fa-rotate-270"

            module Flips =
                let [<Literal>] Horizontal = "fa-flip-horizontal"
                let [<Literal>] Vertical = "fa-flip-vertical"

            module Animations =
                let [<Literal>] Spin = "fa-spin"
                let [<Literal>] Pulse = "fa-pulse"

            module Borders =
                let [<Literal>] Border = "fa-border"

            module Pulls =
                let [<Literal>] PullRight = "fa-pull-right"
                let [<Literal>] PullLeft = "fa-pull-left"

            module StackSizes =
                let [<Literal>] Fa1x = "fa-stack-1x"
                let [<Literal>] Fa2x = "fa-stack-2x"

            module Colors =
                let [<Literal>] Inverse = "fa-inverse"

            module Style =
                let [<Literal>] Solid = "fas"
                let [<Literal>] Regular = "far"
                let [<Literal>] Light = "fal"
                let [<Literal>] Brands = "fab"

        type IStyle =
            | Solid
            | Regular
            | Light

        module Types =

            type IIconSize =
                | FaSmall
                | FaMedium
                | FaLarge
                | Fa2x
                | Fa3x
                | Fa4x
                | Fa5x
                | Fa7x
                | Fa10x
                | Fw

            type IBorder = FaBorder

            type IPull =
                | PullLeft
                | PullRight

            type IAnimation =
                | Spin
                | Pulse

            type IRotation =
                | Rotate90
                | Rotate180
                | Rotate270

            type IFLip =
                | Horizontal
                | Vertical

            type IColor =
                | Inverse

            type IStackSize =
                | FaStack1x
                | FaStack2x

            type IconOption =
                | Size of IIconSize
                | Border of IBorder
                | Pull of IPull
                | Rotation of IRotation
                | Flip of IFLip
                | Color of IColor
                | Icon of IFontAwesomeIcon * IStyle
                | Brand of IFontAwesomeIcon
                | Animation of IAnimation
                | IsLi

            type StackParentOption =
                | ParentSize of IIconSize

            type StackChildOption =
                | ChildSize of IStackSize
                | ChildColor of IColor
                | ChildIcon of IFontAwesomeIcon * IStyle
                | ChildBrand of IFontAwesomeIcon

            let ofSize =
                function
                | FaSmall -> Classes.IconSizes.FaSmall
                | FaMedium -> Classes.IconSizes.FaMedium
                | FaLarge -> Classes.IconSizes.FaLarge
                | Fa2x -> Classes.IconSizes.Fa2x
                | Fa3x -> Classes.IconSizes.Fa3x
                | Fa4x -> Classes.IconSizes.Fa4x
                | Fa5x -> Classes.IconSizes.Fa5x
                | Fa7x -> Classes.IconSizes.Fa7x
                | Fa10x -> Classes.IconSizes.Fa10x
                | Fw -> Classes.IconSizes.Fw

            let ofChildSize =
                function
                | FaStack1x -> Classes.StackSizes.Fa1x
                | FaStack2x -> Classes.StackSizes.Fa2x

            let ofBorder =
                function
                | FaBorder -> Classes.Borders.Border

            let ofPull =
                function
                | PullLeft -> Classes.Pulls.PullLeft
                | PullRight -> Classes.Pulls.PullRight

            let ofAnimation =
                function
                | Spin -> Classes.Animations.Spin
                | Pulse -> Classes.Animations.Pulse

            let ofRotation =
                function
                | Rotate90 -> Classes.Rotations.Rotate90
                | Rotate180 -> Classes.Rotations.Rotate180
                | Rotate270 -> Classes.Rotations.Rotate270

            let ofFlip =
                function
                | Horizontal -> Classes.Flips.Horizontal
                | Vertical -> Classes.Flips.Vertical

            let ofStyle =
                function
                | (Solid, icon) -> Classes.Style.Solid + " " + unbox<string> icon
                | (Regular, icon) -> Classes.Style.Regular + " " + unbox<string> icon
                | (Light, icon) -> Classes.Style.Light + " " + unbox<string> icon

            let ofColor =
                function
                | Inverse -> Classes.Colors.Inverse

            let ofBrand icon =
                Classes.Style.Brands + " " + unbox<string> icon

            type IconOptions =
                { Icon : string option
                  Size : string option
                  Border : string option
                  Pull : string option
                  Animation : string option
                  Rotation : string option
                  Flip : string option
                  Color : string option
                  IsLi : bool }
                with
                static member Empty =
                    { Icon = None
                      Size = None
                      Border = None
                      Pull = None
                      Animation = None
                      Rotation = None
                      Flip = None
                      Color = None
                      IsLi = false }

            type StackParentOptions = { Size : string option }
                with static member Empty = { Size = None }

            type StackChildOptions =
                { Size : string option
                  Color : string option
                  Icon : string option }
                with
                static member Empty =
                    { Size = None
                      Color = None
                      Icon = None }

        open Types

        let icon (i: IFontAwesomeIcon, style: IStyle) = IconOption.Icon (i, style)
        let brand (b: IFontAwesomeIcon) = IconOption.Brand b
        let faXs = IconOption.Size FaSmall
        let faMd = IconOption.Size FaMedium
        let faLg = IconOption.Size FaLarge
        let fa2x = IconOption.Size Fa2x
        let fa3x = IconOption.Size Fa3x
        let fa4x = IconOption.Size Fa4x
        let fa5x = IconOption.Size Fa5x
        let fa7x = IconOption.Size Fa7x
        let fa10x = IconOption.Size Fa10x
        let fw = IconOption.Size Fw
        let border = IconOption.Border FaBorder
        let pullLeft = IconOption.Pull PullLeft
        let pullRight = IconOption.Pull PullRight
        let rotate90 = IconOption.Rotation Rotate90
        let rotate180 = IconOption.Rotation Rotate180
        let rotate270 = IconOption.Rotation Rotate270
        let spin = IconOption.Animation Spin
        let pulse = IconOption.Animation Pulse
        let flipHorizontal = IconOption.Flip Horizontal
        let flipVertical = IconOption.Flip Vertical
        let colorInverse = IconOption.Color Inverse
        let isLi = IconOption.IsLi

        module Child =
            let faStack2x = StackChildOption.ChildSize FaStack2x
            let faStack1x = StackChildOption.ChildSize FaStack1x
            let colorInverse = StackChildOption.ChildColor Inverse
            let icon (i: IFontAwesomeIcon, style: IStyle) = StackChildOption.ChildIcon (i, style)
            let brand (b: IFontAwesomeIcon) = StackChildOption.ChildBrand b

        //Stack Parent Functions
        module Parent =
            let faXs = StackParentOption.ParentSize FaSmall
            let faMd = StackParentOption.ParentSize FaMedium
            let faLg = StackParentOption.ParentSize FaLarge
            let fa2x = StackParentOption.ParentSize Fa2x
            let fa3x = StackParentOption.ParentSize Fa3x
            let fa4x = StackParentOption.ParentSize Fa4x
            let fa5x = StackParentOption.ParentSize Fa5x
            let fa7x = StackParentOption.ParentSize Fa7x
            let fa10x = StackParentOption.ParentSize Fa10x

    module Icon =

        open Fa5.Types

        let stackChild (faOptions: StackChildOption list ) =
            let parseOptions (result: StackChildOptions) (option: StackChildOption) =
                    match option with
                    | ChildSize s ->
                        { result with Size = ofChildSize  s |> Some }

                    | ChildColor c ->
                        { result with Color = ofColor c |> Some }

                    | ChildIcon (faIcon, style) ->
                        { result with Icon = ofStyle (style, faIcon) |> Some }

                    | ChildBrand faBrand ->
                        { result with Icon = ofBrand faBrand |> Some }

            let opts = faOptions |> List.fold parseOptions StackChildOptions.Empty
            i [ Helpers.classes ""  [ opts.Icon; opts.Size; opts.Color ] [ ] ] [ ]

        let stackParent (faOptions: StackParentOption list) children =
            let parseOptions (result: StackParentOptions) (option: StackParentOption) =
                    match option with
                    | ParentSize s -> { result with Size = ofSize s  |> Some }

            let opts = faOptions |> List.fold parseOptions StackParentOptions.Empty
            span [ Helpers.classes "fa-stack" [ opts.Size ] [ ] ] children

        let toIconOptions (faOptions: IconOption list) =
            let parseOptions (result: IconOptions) (option: IconOption) =
                    match option with
                    | Size s ->
                        { result with Size = ofSize s |> Some }

                    | Border b ->
                        { result with Border = ofBorder b |> Some }

                    | Pull p ->
                        { result with Pull = ofPull p |> Some }

                    | Icon (faIcon, style) ->
                        { result with Icon = ofStyle (style, faIcon) |> Some }

                    | Brand faBrand ->
                        { result with Icon = ofBrand faBrand |> Some }

                    | Rotation r ->
                        { result with Rotation = ofRotation r |> Some }

                    | Flip f ->
                        { result with Rotation = ofFlip f |> Some }

                    | Color i ->
                        { result with Color = ofColor i |> Some }

                    | Animation a ->
                        { result with Animation = ofAnimation a |> Some }

                    | IsLi ->
                        { result with IsLi = false }

            faOptions |> List.fold parseOptions IconOptions.Empty

        let faIcon (options: Fulma.Icon.Option list) (faOptions: IconOption list) =
            let opts = toIconOptions faOptions
            Icon.icon options
                [ i [ Helpers.classes ""
                        [ opts.Icon; opts.Size; opts.Border
                          opts.Pull; opts.Animation; opts.Rotation
                          opts.Flip; opts.Color ] [] ] [] ]

        let fa_ul (options: GenericOption list) children =
            let opts = genericParse options
            let classes = Helpers.classes "fa-ul" [ opts.CustomClass ] [ ]
            ul (classes::opts.Props) children