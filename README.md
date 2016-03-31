#CM3D2.ManProp.Plugin

標準では2人目・3人目の男には「mhead001_i_.menu」が適用されますが、
それを変更することが出来ます。
ただし、ゲーム起動前時のみ変更できます。


##適用方法

「CM3D2.ManProp.Plugin.dll」を「UnityInjectorフォルダ」、
「Config/ManProp.ini」を「UnityInjector/Configフォルダ」に入れてください。


##MENUの変更方法
ManProp.iniを以下を参考に書き換えてください。

* 0=（2人目に適用するMENUファイル名）
* 1=（3人目に適用するMENUファイル名）

（2=4人目... と対応していますが、現在公式で3人以上の場面はないと思います）

標準の男MENUファイル名は「mhead000_i_.menu」...「mhead004_i_.menu」です。


##男用セットのMENUファイルについて（任意）

体・顔・各数値を細かく調整したい場合は、セットMENUファイルを作成する方法をオススメします。
「MenuSample/_man1_i.menu」を参考に書き換え、しばりすなどでゲーム内に追加してください。

##更新履歴

1.0.0.0 初版
