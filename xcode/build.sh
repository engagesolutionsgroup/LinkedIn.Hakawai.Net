#!/bin/sh

# Define the output directories
IPHONEOS_OUTPUT_DIR="../output/Frameworks/Release-iphoneos"
IPHONESIMULATOR_OUTPUT_DIR="../output/Frameworks/Release-iphonesimulator"
# Define the output directory for Mac Catalyst
MACCATALYST_OUTPUT_DIR="../output/Frameworks/Release-maccatalyst"

# Run xcodebuild for Mac Catalyst (both x86_64 and arm64)
XCFRAMEWORK_OUTPUT_DIR="../output/"
FRAMEWORK_NAME="Hakawai"
# Run xcodebuild for iphoneos
xcodebuild archive -scheme Hakawai -destination "generic/platform=iOS" -archivePath $IPHONEOS_OUTPUT_DIR

# Run xcodebuild for iphonesimulator
xcodebuild archive -scheme Hakawai -destination "generic/platform=iOS Simulator" -archivePath $IPHONESIMULATOR_OUTPUT_DIR

#Run xcodebuild for MacCatalyst
xcodebuild archive -scheme Hakawai -destination "generic/platform=macOS,variant=Mac Catalyst" -archivePath $MACCATALYST_OUTPUT_DIR

#create xcframework 
xcodebuild -create-xcframework \
   -archive "$IPHONEOS_OUTPUT_DIR.xcarchive"  -framework $FRAMEWORK_NAME.framework \
   -archive "$IPHONESIMULATOR_OUTPUT_DIR.xcarchive" -framework $FRAMEWORK_NAME.framework \
   -archive "$MACCATALYST_OUTPUT_DIR.xcarchive" -framework $FRAMEWORK_NAME.framework \
   -output "$XCFRAMEWORK_OUTPUT_DIR/$FRAMEWORK_NAME.xcframework" 