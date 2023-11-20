#!/bin/sh

# Define the output directories
IPHONEOS_OUTPUT_DIR="../output/Frameworks/Release-iphoneos"
IPHONESIMULATOR_OUTPUT_DIR="../output/Frameworks/Release-iphonesimulator"
XCFRAMEWORK_OUTPUT_DIR="../output/"
FRAMEWORK_NAME="Hakawai"
# Run xcodebuild for iphoneos
xcodebuild -configuration Release -sdk iphoneos CONFIGURATION_BUILD_DIR="$IPHONEOS_OUTPUT_DIR"

# Run xcodebuild for iphonesimulator
xcodebuild -configuration Release -sdk iphonesimulator CONFIGURATION_BUILD_DIR="$IPHONESIMULATOR_OUTPUT_DIR"

#create xcframework 
xcodebuild -create-xcframework \
    -framework "$IPHONEOS_OUTPUT_DIR/$FRAMEWORK_NAME.framework" \
    -framework "$IPHONESIMULATOR_OUTPUT_DIR/$FRAMEWORK_NAME.framework" \
    -output "$XCFRAMEWORK_OUTPUT_DIR/$FRAMEWORK_NAME.xcframework"