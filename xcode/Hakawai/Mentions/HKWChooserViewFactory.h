//
//  HKWChooserViewFactory.h
//  Hakawai
//
//  Created by Artem Valieiev on 20.12.2023.
//

#import <UIKit/UIKit.h>

@protocol HKWChooserViewFactory <NSObject>

- (id<HKWChooserViewProtocol>)chooserViewWithFrame:(CGRect)frame;

@end
