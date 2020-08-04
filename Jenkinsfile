pipeline {
  agent any
  stages {
    stage('Restore nuget') {
      steps {
        sh '''export PATH=/Library/Frameworks/Mono.framework/Versions/Current/bin/:${PATH}
nuget restore'''
      }
    }

    stage('Build iOS') {
      parallel {
        stage('Build iOS') {
          steps {
            sh '''export PATH=/Library/Frameworks/Mono.framework/Versions/Current/bin/:${PATH}
msbuild ${PROJECT_NAME}.sln /t:${PROJECT_NAME}_iOS /p:Configuration="Release" /p:BuildIpa=true /p:Platform="iPhone" /p:IpaPackageDir="$WORKSPACE/Builds" '''
          }
        }

        stage('Build Android') {
          steps {
            sh '''export PATH=/Library/Frameworks/Mono.framework/Versions/Current/bin/:${PATH}
msbuild ${PROJECT_NAME}.sln /t:${PROJECT_NAME}_Android /p:Configuration="Release" /p:AndroidBuildApplicationPackage=true'''
          }
        }

      }
    }

    stage('signing android') {
      steps {
        sh '''jarsigner -verbose -sigalg MD5withRSA -digestalg SHA1 -keystore $KEYSTORE_FILE -storepass $STORE_PASS -signedjar $WORKSPACE/${PROJECT_NAME}.Android/bin/Release/com.unosquare.${APK_NAME}-signed.apk $WORKSPACE/${PROJECT_NAME}.Android/bin/Release/com.unosquare.${APK_NAME}.apk $KEYSTORE_ALIAS  
${ANDROID_HOME}/build-tools/29.0.2/zipalign -f -v 4 $WORKSPACE/${PROJECT_NAME}.Android/bin/Release/com.unosquare.${APK_NAME}-signed.apk $WORKSPACE/Builds/${APK_NAME}-Release.apk'''
      }
    }

  }
  environment {
    PATH_build = '/Library/Frameworks/Mono.framework/Versions/Current/Commands:$PATH'
    PROJECT_NAME = 'EjercicioTecnico'
    APK_NAME = 'EjercicioTecnico'
    ANDROID_HOME = '~/Library/Developer/Xamarin/android-sdk-macosx'
    KEYSTORE_FILE = '~/cubesmart.keystore'
    KEYSTORE_ALIAS = 'cubesmart'
    INPUT_APK = '${WORKSPACE}/${PROJECT_NAME}.Android/bin/Release/com.unosquare.${APK_NAME}.apk'
    SIGNED_APK = '${WORKSPACE}/${PROJECT_NAME}.Android/bin/Release/com.unosquare.${APK_NAME}-signed.apk'
    FINAL_APK = '${WORKSPACE}/Builds/${APK_NAME}-Release.apk'
    STORE_PASS = 'cubesmart'
  }
}