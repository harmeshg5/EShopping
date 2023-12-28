import { Component, EventEmitter, OnInit, Output } from "@angular/core";


@Component({
    selector: 'app-imageupload',
    templateUrl: './ImageUpload.component.html',
    standalone: true
})
export class ImageUploadComponent implements OnInit {

    i: number;
    imgUrl: string = "https://picsum.photos/seed/picsum/200/300";

    @Output() myEvent = new EventEmitter<string>();

    emitMsgOnImageChange() {
        return this.myEvent.emit('Hello, I am emitted from ImageUpload Component.ts');
    }

    constructor() {
        this.i = 1014;
    }

    ngOnInit(): void {
    }



    changeImageUrl() {
        this.i = this.i + 1;
        console.log('https://picsum.photos/id/' + this.i + '/237/200/300');
        this.imgUrl = 'https://picsum.photos/id/' + this.i + '/200/300';
        this.emitMsgOnImageChange();
    }

}