# このリポジトリについて
神ゲー創造エボリューションのゲーム作品で、ChatGPTを利用してテキストを生成する機能を実装しました。このリポジトリでは作成したソースコードをまとめています。

# ダウロード方法
releaseからunitypackageをダウンロードしてください

# 必要なツール
・[UniTask](https://github.com/Cysharp/UniTask) \
・[Newtonsoft.Json-for-Unity](https://github.com/applejag/Newtonsoft.Json-for-Unity)　\
・[NaughtyAttributes](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996?locale=ja-JP) 

Newtonsoft.Json-for-のUPMダウンロードについてですが、ドキュメントのUPMリンクの``com.unity.nuget.newtonsoft-json@3``でダウンロード出来なかったので、[Newtonsoft.Jsonの基本的な使い方](https://qiita.com/kazuma_f/items/55a0b7ff628ab596e6ee)のUPMリンクでダウンロードしました。@3を抜けばダウンロードできるみたいです。
```C#
com.unity.nuget.newtonsoft-json
```

# 参考にした記事
・[ChatGPT APIをUnityから動かす。](https://note.com/negipoyoc/n/n88189e590ac3) \
・[GPT-4oをUnityで動かす](https://note.com/361yohen/n/n9d91a80002ab) \
・[Newtonsoft.Jsonの基本的な使い方](https://qiita.com/kazuma_f/items/55a0b7ff628ab596e6ee)

# 注意点
テキスト生成と画像解析を利用するには、[OpenAI API](https://openai.com/index/openai-api/)サービスを利用してAPIキーを作成する必要があります。利用状況によって料金がかかるのでご注意ください。

# 利用方法
1. GameObjectにSentenceGeneratorをアタッチします。\
![image](https://github.com/user-attachments/assets/43f6e850-c3ca-41c4-92e8-982b0f173fd5)

2. APIキーをインスペクターから入力します。\
![image](https://github.com/user-attachments/assets/229e7704-7798-434c-b528-07459de61164)

3. GPTの返答方法を入力します。\
![image](https://github.com/user-attachments/assets/c4cf8bdd-64b7-4fa7-8ec1-176b291570a9)

4. APIのモデルを設定します。\
画像解析のみGPT-4o,GPT-4o-miniしか対応していないのでご注意ください。現在、GPT-4o-miniで画像解析を行うと使用トークンがとても高くなるということが起こるので、画像解析にはGPT-4oを推奨します。
![image](https://github.com/user-attachments/assets/b8b1906e-2f02-46a1-ab44-35dac948cfaa)
![image](https://github.com/user-attachments/assets/70fd4bd1-178d-4fd1-bafe-57de3981ad2f) \
他のGPTのバージョンを追加したい場合はModelListにバージョンを追加してください。バージョンによっては3.5などコード内で直接書けない単語が出てくるので＿などで置き換えてModelListConverterで文字を変換する処理を追加してください。\
![image](https://github.com/user-attachments/assets/685f148f-7ed1-4d6e-b315-049ca9baf668)![image](https://github.com/user-attachments/assets/7f83a21a-a3a5-448f-bcdf-4bff3f279b75)

6. インスペクターから最大使用トークンを設定します。\
![image](https://github.com/user-attachments/assets/dbeb6020-8c35-44b6-8214-7603e30839a5)

7. デバックログを出力するフラグを設定できます。\
![image](https://github.com/user-attachments/assets/21d55d4b-5bb0-43f9-be5f-22fb7a1298a4)

8. インスペクターからプロンプトの初期化、チャット・画像送信をすることができます。
プレイモード中にしか実行できないようになっています。また、プロンプトの初期化についてはインスペクターから行ってください。メソッドから変更することも可能です。\
![image](https://github.com/user-attachments/assets/c46cf668-8640-404f-a6a8-ad91e60276f8)

# 参照方法
インタフェースのISentenceGeneratorをSentenceGeneratorに実装しているので、インタフェースから参照することができます。\
![image](https://github.com/user-attachments/assets/9b278597-f9f1-435d-9be9-91e4a134dfb3)
今回のコードでは含まれていませんが、私はサービスロケーターを利用して参照を行いました。
